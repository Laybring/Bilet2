namespace Bilet2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            string symb1 = "ABCDEFGHIJKLMNOPRSTUVWXYZ";

            if (textBox2.Text.IndexOfAny(symb1.ToCharArray()) >= 1 
                & textBox2.Text.Length >= 5 
                & textBox2.Text.Contains("@") 
                & textBox2.Text.Contains(",") 
                & textBox2.Text.Contains("!")
                )
            {
                using ConnectDB db = new ConnectDB();
                {
                    db.ExecuteSqlNonQuery($"INSERT INTO USERS VALUES ('{login}', '{password}', '1')");
                    MessageBox.Show("�� ������� ������������������!");
                }
            }
            else
            {
                MessageBox.Show("������ �� ������������� �����������. ����������� � ������ �� ����� 5 ��������, ������� �������� � ������� ��������, � ����� ����� @ ! ,");
            }
        }
    }
}