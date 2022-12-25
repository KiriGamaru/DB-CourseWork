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
                //������ ��������� ������
            SqlConnectionStringBuilder sqlConnectionString = new();

            sqlConnectionString.DataSource = @"(LocalDB)\MSSQLLocalDB";
            sqlConnectionString.AttachDBFilename = @"J:\DB\KGBD.mdf";
            sqlConnectionString.IntegratedSecurity = true;
            sqlConnectionString.ConnectTimeout = 30;

            //������� � ���� ������ ���������
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
                    MessageBox.Show("������������ ������");
                }

            }
        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                pbGenerator.Value = 0; // ���������� ��������
                pbGenerator.Maximum = (int)udCount.Value; // ������ ������������

                // ������� �������� � ������� ������������ �������� ����� � ��������� �� �����
                var buns = new Dictionary<string, TrackBar>
                {
                    ["������"] = tb1,
                    ["������"] = tb2,
                    ["��������"] = tb3,
                    ["�������"] = tb4,
                    ["�������"] = tb5,
                    ["��������"] = tb6,
                    ["�����"] = tb7,
                    ["������"] = tb8,
                    ["� ��������"] = tb9,
                    ["������"] = tb10,
                    ["�����"] = tb11,
                    ["����� ����������"] = tb12,
                    ["��������"] = tb13,
                    ["��������"] = tb14,
                };

                // ������������ ��������� �������� �� ���������
                int totalBuns = buns.Values.Sum(tb => tb.Value);

                // ������� �������� ��� ������������� ����� -- ����������
                Dictionary<string, Range> bunsProbablity = new();
                double previousProbabilty = 0;
                // �� � ��������������� ���������
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

                // ������� ��������� ��������� �����
                Random rnd = new();
                // � �������� � ����� ��������� ������ � ��,
                // � ����� ��������� �� ���������� ������� ��������� � ���� udCount
                for (var i = 0; i < udCount.Value; ++i)
                {
                    string bun = null;
                    var k = rnd.NextDouble(); // ������� ��������� ����� �� 0 �� 1

                    // �������� �� ����� ������������
                    foreach (var item in bunsProbablity)
                    {
                        // ���� �������� �������� � ���������� 
                        if (item.Value.CheckContains(k))
                        {
                            bun = item.Key; // �� ��������� �������� ������
                            break; // � ������� �� �����
                        }
                    }

                    if (bun == null)
                        continue;

                    //������� ������
                    var s = rnd.Next(1, 3);
                    String size = "";
                    switch (s)
                    {
                        case 1:
                            size = "���������";
                            break;
                        case 2:
                            size = "�������";
                            break;
                        case 3:
                            size = "�������";
                            break;
                    }

                    //������� ����� ���������� �����������
                    var secretIngredient = rnd.Next(1, 14);

                    // �������� ������
                    SqlCommand command = new($@"
INSERT INTO Buns(name,Size,SecretIngredient)
VALUES(N'{bun}',N'{size}',N'{secretIngredient}')"
, connection);
                    command.ExecuteNonQuery(); // ��������� ������, ��� ������������� �������� ���-������ � �����
                    pbGenerator.Value++; // ����������� �������� �� 1
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
            MessageBox.Show("��������� ������ �������");
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
            MessageBox.Show("��������� ������ �������");
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