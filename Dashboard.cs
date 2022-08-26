using System.Data;
using System.Data.SqlClient;

namespace BookShop
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nikita\Desktop\c#\BookShop\BookShopDb.mdf;Integrated Security=True");

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }


        private void label6_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            us.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select sum(Bquantity) from booktbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            stockLabel.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("Select Count(uid) from usertbl", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            amountLabel.Text = dt1.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("Select sum(Amount) from billtbl", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            salesLabel.Text = dt2.Rows[0][0].ToString();
            Con.Close();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Show();
            this.Hide();
        }


    }
}
