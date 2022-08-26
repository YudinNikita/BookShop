using System.Data;
using System.Data.SqlClient;

namespace BookShop
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            Populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nikita\Desktop\c#\BookShop\BookShopDb.mdf;Integrated Security=True");

        private void Populate()
        {
            Con.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            usersDataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uSaveButton_Click(object sender, EventArgs e)
        {
            if (uUsernameTextBox.Text == "" || uPhoneTextBox.Text == "" || uAddressTextBox.Text == "" || uPasswordTextBox.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UserTbl values('" + uUsernameTextBox.Text + "', '" + uPhoneTextBox.Text + "', '" + uAddressTextBox.Text + "', '" + uPasswordTextBox.Text + "' )";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Succesfully Saved");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }
        private void Reset()
        {
            uUsernameTextBox.Text = "";
            uPhoneTextBox.Text = "";
            uPasswordTextBox.Text = "";
            uAddressTextBox.Text = "";

        }

        private void uResetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;


        private void uDeleteButton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from userTbl where Uid=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Succesfully Saved");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }

        private void uEditButton_Click(object sender, EventArgs e)
        {
            if (uUsernameTextBox.Text == "" || uPhoneTextBox.Text == "" || uPasswordTextBox.Text == "" || uAddressTextBox.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update usertbl set uname = '" + uUsernameTextBox.Text + "',uphone = '" + uPhoneTextBox.Text + "', uaddress = '" + uAddressTextBox.Text + "', upass = '" + uPasswordTextBox.Text + "' Where Uid = " + key + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Succesfully Saved");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    Con.Close();
                }
            }
        }



        private void usersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            uUsernameTextBox.Text = usersDataGridView.SelectedCells[1].Value.ToString();
            uPhoneTextBox.Text = usersDataGridView.SelectedCells[2].Value.ToString();
            uAddressTextBox.Text = usersDataGridView.SelectedCells[3].Value.ToString();
            uPasswordTextBox.Text = usersDataGridView.SelectedCells[4].Value.ToString();

            if (uUsernameTextBox.Text == "")
            {
                key = 0;

            }
            else key = Convert.ToInt32(usersDataGridView.SelectedCells[0].Value.ToString());
        }



        private void label4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
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
