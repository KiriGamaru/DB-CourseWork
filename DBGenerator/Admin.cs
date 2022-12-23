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
    }
}