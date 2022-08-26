using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            Populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nikita\Desktop\c#\BookShop\BookShopDb.mdf;Integrated Security=True");

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

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int key = 0, stock =0;

        private void booksDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bTitleTextBox.Text = booksDataGridView.SelectedCells[1].Value.ToString();
            //bQuantityTextBox.Text = booksDataGridView.SelectedCells[4].Value.ToString();
            bPriceTextBox.Text = booksDataGridView.SelectedCells[5].Value.ToString();
            if (bTitleTextBox.Text == "")
            {
                key = 0;
                stock = 0;
            }
            else
            {
                key = Convert.ToInt32(booksDataGridView.SelectedCells[0].Value.ToString());
                stock = Convert.ToInt32(booksDataGridView.SelectedCells[4].Value.ToString());
            }
        }
        private void Reset()
        {
            bTitleTextBox.Text = "";
            bQuantityTextBox.Text = "";
            clientNameTextBox.Text = "";
            bPriceTextBox.Text = "";

        }

        private void uResetButton_Click(object sender, EventArgs e)
        {
            Reset();

        }
        private void UpdateBook() 
        {
            int newQuantity = stock - Convert.ToInt32(bQuantityTextBox.Text);
            try
            {
                Con.Open();
                string query = "update BookTbl set bQuantity = " + newQuantity+ "Where Bid = " + key + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Book Succesfully Updated");
                Con.Close();
                Populate();
               // Reset();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            stock =- Convert.ToInt32(bQuantityTextBox.Text);
        }
        int n = 0,grdTotal=0;

      
        int prodid, prodqty, prodprice, tottal, pos = 100;

        private void label4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = Login.UserName;
        }

        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Book Shop", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID Product Price Quantity Total", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26,40));
            foreach (DataGridViewRow row in billDataGridView.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);
                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos +=30;
            }
            e.Graphics.DrawString("Grand Total: "+ grdTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(60,pos+150));
            e.Graphics.DrawString("**********Book Store**********", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Crimson, new Point(40,pos+180));

            billDataGridView.Rows.Clear();
            billDataGridView.Refresh();
            pos = 100;
            grdTotal = 0;
        }

        private void uSaveButton_Click(object sender, EventArgs e)
        {
        
            if (bTitleTextBox.Text == "" || Convert.ToInt32(bQuantityTextBox.Text) > stock)
                MessageBox.Show("Not enough books in stock");
            else
            {
                int total = Convert.ToInt32(bQuantityTextBox.Text) * Convert.ToInt32(bPriceTextBox.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(billDataGridView);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = bTitleTextBox.Text;
                newRow.Cells[2].Value = bQuantityTextBox.Text;
                newRow.Cells[3].Value = bPriceTextBox.Text;
                newRow.Cells[4].Value = total;
                billDataGridView.Rows.Add(newRow);
                n++;
                UpdateBook();
                grdTotal +=total;
                totalLabel.Text = "Total: "+ grdTotal.ToString();

            }

        }
        private void uEditButton_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);

            if (bTitleTextBox.Text == "" || clientNameTextBox.Text == "")
            {
                MessageBox.Show("Select Client Name");
            }
            else
            {
          
                try
                {
                    Con.Open();
                    string query = "insert into BillTbl values('" + usernameLabel.Text + "', '" + clientNameTextBox.Text + "', " + grdTotal + " )";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Bill Succesfully Saved");
                    Con.Close();
                    //Populate();
                    //Reset();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }
    }
}
