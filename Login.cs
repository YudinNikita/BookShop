using System.Data;
using System.Data.SqlClient;

namespace BookShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nikita\Desktop\c#\BookShop\BookShopDb.mdf;Integrated Security=True");
        public static string UserName = "";
        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT COUNT(*) FROM userTbl WHERE uName='" + usernameTextBox.Text + "'and upass='" + passwordTextBox.Text + "'and Uid = 510", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            if (dt1.Rows[0][0].ToString() == "1")
            {
                UserName = usernameTextBox.Text;
                Books obj = new Books();
                obj.Show();
                this.Hide();
                Con.Close();
            }
            else if (dt1.Rows[0][0].ToString() == "0")
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM userTbl WHERE uName='" + usernameTextBox.Text + "'and upass='" + passwordTextBox.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    UserName = usernameTextBox.Text;
                    Billing obj = new Billing();
                    obj.Show();
                    this.Hide();
                    Con.Close();
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }

            Con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
