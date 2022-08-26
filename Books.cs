using System.Data;
using System.Data.SqlClient;


namespace BookShop
{
    public partial class Books : Form
    {


        public Books()
        {
            InitializeComponent();
            Populate();
        }
        private void Populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            booksDataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Filter()
        {
            Con.Open();
            string query = "select * from BookTbl WHERE bcategory='" + bFilterComboBox.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            booksDataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nikita\Desktop\c#\BookShop\BookShopDb.mdf;Integrated Security=True");
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (bTitleTextBox.Text == "" || bAuthorTextBox.Text == "" || bQuantityTextBox.Text == "" || bPriceTextBox.Text == "" || bCategoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into BookTbl values('" + bTitleTextBox.Text + "', '" + bAuthorTextBox.Text + "', '" + bCategoryComboBox.SelectedItem.ToString() + "', " + bQuantityTextBox.Text + ", " + bPriceTextBox.Text + " )";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Succesfully Saved");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void FilterComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Filter();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Populate();
            bFilterComboBox.SelectedIndex = -1;

        }

        private void Reset()
        {
            bTitleTextBox.Text = "";
            bAuthorTextBox.Text = "";
            bQuantityTextBox.Text = "";
            bPriceTextBox.Text = "";
            bCategoryComboBox.SelectedIndex = -1;

        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
        int key = 0;


        private void deleteButton_Click(object sender, EventArgs e)
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
                    string query = "delete from BookTbl where Bid=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Succesfully Deleted");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (bTitleTextBox.Text == "" || bAuthorTextBox.Text == "" || bQuantityTextBox.Text == "" || bPriceTextBox.Text == "" || bCategoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update BookTbl set btitle = '" + bTitleTextBox.Text + "',Bauthor = '" + bAuthorTextBox.Text + "',bcategory = '" + bCategoryComboBox.SelectedItem.ToString() + "', bQuantity = " + bQuantityTextBox.Text + ", Bprice = " + bPriceTextBox.Text + " Where Bid = " + key + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Succesfully Updated");
                    Con.Close();
                    Populate();
                    Reset();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }



        private void usersPanel_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            us.Show();
            this.Hide();
        }

        private void booksDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bTitleTextBox.Text = booksDataGridView.SelectedCells[1].Value.ToString();
            bAuthorTextBox.Text = booksDataGridView.SelectedCells[2].Value.ToString();
            bCategoryComboBox.SelectedItem = booksDataGridView.SelectedCells[3].Value.ToString();
            bQuantityTextBox.Text = booksDataGridView.SelectedCells[4].Value.ToString();
            bPriceTextBox.Text = booksDataGridView.SelectedCells[5].Value.ToString();
            if (bTitleTextBox.Text == "")
            {
                key = 0;

            }
            else key = Convert.ToInt32(booksDataGridView.SelectedCells[0].Value.ToString());

        }

        private void dashboardPanel_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }



        private void label4_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
