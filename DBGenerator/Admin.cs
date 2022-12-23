using System.Data;
using System.Data.SqlClient;

namespace DBGenerator
{
    public partial class Form1 : Form
    {
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
                using (var reader = command.ExecuteReader())
                {
                    DataTable table = new();
                    table.Load(reader);
                    dgName.DataSource = table;
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
    }
}