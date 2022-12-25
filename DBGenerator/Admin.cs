using System.Data;
using System.Data.SqlClient;

namespace DBGenerator
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new();

        struct Range
        {
            public double min;
            public double max;

            public bool CheckContains(double value)
            {
                return min <= value && value <= max;
            }
        }

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public SqlConnection GetConnection()
        {

            SqlConnection connection = new();
                //создаём экземпляр класса
            SqlConnectionStringBuilder sqlConnectionString = new();

            sqlConnectionString.DataSource = @"(LocalDB)\MSSQLLocalDB";
            sqlConnectionString.AttachDBFilename = @"J:\DB\KGBD.mdf";
            sqlConnectionString.IntegratedSecurity = true;
            sqlConnectionString.ConnectTimeout = 30;

            //передаём в виде текста конекшену
            connection.ConnectionString = sqlConnectionString.ToString();
            return connection;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                SqlCommand command = new(txtQuery.Text, connection);
                try
                {
                    using (var reader = command.ExecuteReader())
                    {
                        DataTable table = new();
                        table.Load(reader);
                        dgName.DataSource = table;
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Неправильный запрос");
                }

            }
        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                pbGenerator.Value = 0; // сбрасываем значение
                pbGenerator.Maximum = (int)udCount.Value; // ставим максимальное

                // создаем словарик в котором сопоставляем название булки с трекбаром на форме
                var buns = new Dictionary<string, TrackBar>
                {
                    ["Бублик"] = tb1,
                    ["Плюшка"] = tb2,
                    ["Круассан"] = tb3,
                    ["Рогалик"] = tb4,
                    ["Калачик"] = tb5,
                    ["Крендель"] = tb6,
                    ["Сайка"] = tb7,
                    ["Слойка"] = tb8,
                    ["С посыпкой"] = tb9,
                    ["Бриошь"] = tb10,
                    ["Рулет"] = tb11,
                    ["Сдоба выборгская"] = tb12,
                    ["Пампушка"] = tb13,
                    ["Ватрушка"] = tb14,
                };

                // рассчитываем суммарное значение на трекбарах
                int totalBuns = buns.Values.Sum(tb => tb.Value);

                // создаем словарик для сопоставления булка -- промежуток
                Dictionary<string, Range> bunsProbablity = new();
                double previousProbabilty = 0;
                // ну и последовательно заполняем
                foreach (var item in buns)
                {
                    double k = (double)buns[item.Key].Value / totalBuns;
                    if (k > 0)
                    {
                        bunsProbablity[item.Key] = new Range
                        {
                            min = previousProbabilty,
                            max = previousProbabilty + k
                        };

                        previousProbabilty += k;
                    }
                }

                // создаем генератор случайных чисел
                Random rnd = new();
                // и начинаем в цикле создавать записи в БД,
                // в цикле повторяем по количеству записей указанных в поле udCount
                for (var i = 0; i < udCount.Value; ++i)
                {
                    string bun = null;
                    var k = rnd.NextDouble(); // бросаем случайное число от 0 до 1

                    // проходим по шкале вероятностей
                    foreach (var item in bunsProbablity)
                    {
                        // если значение попадает в промежуток 
                        if (item.Value.CheckContains(k))
                        {
                            bun = item.Key; // то фиксируем значение породы
                            break; // и выходим из цикла
                        }
                    }

                    if (bun == null)
                        continue;

                    //генерим размер
                    var s = rnd.Next(1, 3);
                    String size = "";
                    switch (s)
                    {
                        case 1:
                            size = "маленький";
                            break;
                        case 2:
                            size = "средний";
                            break;
                        case 3:
                            size = "большой";
                            break;
                    }

                    //генерим номер секретного ингридиента
                    var secretIngredient = rnd.Next(1, 14);

                    // передаем данные
                    SqlCommand command = new($@"
INSERT INTO Buns(name,Size,SecretIngredient)
VALUES(N'{bun}',N'{size}',N'{secretIngredient}')"
, connection);
                    command.ExecuteNonQuery(); // выполняем запрос, без необходимости получить что-нибудь в ответ
                    pbGenerator.Value++; // увеличиваем значение на 1
                }


            }
        }


        private void AddBakers()
        {
            dataBase.openConnection();

            var count = udCountBakers.Value;

            var query = $@"SET NOCOUNT ON;
	
	SELECT row_number() OVER(ORDER BY ID) AS buns_id, ID INTO #buns_ids FROM Buns;

	DECLARE @buns_ids_am BIGINT;
	SELECT @buns_ids_am = COUNT(#buns_ids.ID) FROM #buns_ids;

	DECLARE @ehd_am INT;
	SET @ehd_am = {count};

	CREATE TABLE  #CSV_bakers(
		bakers_id INT PRIMARY KEY,
		bakers_name VARCHAR(50),
		bakers_surname NVARCHAR(50),
	);

	BULK INSERT  #CSV_bakers
	FROM 'J:\DB\CDB\names.csv'
	WITH(
		FIELDTERMINATOR = ';',
		ROWTERMINATOR ='\n',
		FIRSTROW = 2
	);

	WHILE @ehd_am > 0
		BEGIN

			DECLARE @buns_id_new BIGINT;
			SET @buns_id_new = RAND() * @buns_ids_am + 1;

			DECLARE @buns_id BIGINT;

			SELECT @buns_id = #buns_ids.ID FROM #buns_ids WHERE #buns_ids.id = @buns_id_new;

			
			SELECT * INTO #rowd FROM Bakers WHERE ID = @buns_id_new;


			DECLARE @count TINYINT;
			SELECT @count = COUNT(#rowd.ID) FROM #rowd;


			DECLARE @bakers_name NVARCHAR(50);
			DECLARE @bakers_surname NVARCHAR(50);
			SELECT TOP 1 @bakers_name = bakers_name, @bakers_surname = bakers_surname FROM #CSV_bakers ORDER BY NEWID();
			

			IF @count = 0
				INSERT INTO Bakers(Buns, Name, SurName) VALUES(@buns_id, @bakers_name, @bakers_surname);

			SET @ehd_am -= 1;
			DROP TABLE #rowd;
		END
		
			
		DROP TABLE #buns_ids;
		DROP TABLE #CSV_bakers;";

            var command = new SqlCommand(query, dataBase.GetConnection());
            command.ExecuteNonQuery();
            dataBase.closeConnection();
            MessageBox.Show("Генерация прошла успешно");
        }


        private void AddSellers()
        {
            dataBase.openConnection();

            var count = udCountSellers.Value;

            var query = $@"SET NOCOUNT ON;

	CREATE TABLE  #CSV_sellers(
		sellers_id INT PRIMARY KEY,
		sellers_name VARCHAR(50),
		sellers_surname NVARCHAR(50),
	);

	BULK INSERT  #CSV_sellers
	FROM 'J:\DB\CDB\names.csv'
	WITH(
		FIELDTERMINATOR = ';',
		ROWTERMINATOR ='\n',
		FIRSTROW = 2
	);

	DECLARE @sellers_amount BIGINT;
	SET @sellers_amount = {count};

	WHILE @sellers_amount > 0
		BEGIN
			DECLARE @sellers_name NVARCHAR(50);
			DECLARE @sellers_surname NVARCHAR(50);
			SELECT TOP 1 @sellers_name = sellers_name, @sellers_surname = sellers_surname FROM #CSV_sellers ORDER BY NEWID();
			
			INSERT INTO Sellers(name, surname) VALUES(@sellers_name, @sellers_surname);
			SET @sellers_amount -= 1;
		END
	DROP TABLE #CSV_sellers;";


            var command = new SqlCommand(query, dataBase.GetConnection());
            command.ExecuteNonQuery();
            dataBase.closeConnection();
            MessageBox.Show("Генерация прошла успешно");
        }






        private void btnAddBakers_Click(object sender, EventArgs e)
        {
            AddBakers();

        }

        private void btnAddSellers_Click(object sender, EventArgs e)
        {
            AddSellers();
        }
    }
}