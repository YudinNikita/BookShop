namespace BookShop
{
    partial class Billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.uResetButton = new System.Windows.Forms.Button();
            this.uPrintButton = new System.Windows.Forms.Button();
            this.uSaveButton = new System.Windows.Forms.Button();
            this.bQuantityTextBox = new System.Windows.Forms.TextBox();
            this.exitLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bTitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.billDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 46);
            this.label8.TabIndex = 10;
            this.label8.Text = "Book Shop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(48, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 46);
            this.label4.TabIndex = 10;
            this.label4.Text = "Logout";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Purple;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(12, 600);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(218, 56);
            this.panel6.TabIndex = 13;
            this.panel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 680);
            this.panel1.TabIndex = 6;
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToAddRows = false;
            this.booksDataGridView.AllowUserToDeleteRows = false;
            this.booksDataGridView.AllowUserToResizeColumns = false;
            this.booksDataGridView.AllowUserToResizeRows = false;
            this.booksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.booksDataGridView.Location = new System.Drawing.Point(16, 408);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.RowHeadersVisible = false;
            this.booksDataGridView.RowTemplate.Height = 25;
            this.booksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDataGridView.Size = new System.Drawing.Size(404, 248);
            this.booksDataGridView.TabIndex = 23;
            this.booksDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellDoubleClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(160, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 37);
            this.label12.TabIndex = 22;
            this.label12.Text = "Book List";
            // 
            // uResetButton
            // 
            this.uResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.uResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.uResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uResetButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uResetButton.ForeColor = System.Drawing.Color.White;
            this.uResetButton.Location = new System.Drawing.Point(200, 265);
            this.uResetButton.Name = "uResetButton";
            this.uResetButton.Size = new System.Drawing.Size(178, 48);
            this.uResetButton.TabIndex = 20;
            this.uResetButton.Text = "Reset";
            this.uResetButton.UseVisualStyleBackColor = false;
            this.uResetButton.Click += new System.EventHandler(this.uResetButton_Click);
            // 
            // uPrintButton
            // 
            this.uPrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.uPrintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.uPrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uPrintButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uPrintButton.ForeColor = System.Drawing.Color.White;
            this.uPrintButton.Location = new System.Drawing.Point(546, 600);
            this.uPrintButton.Name = "uPrintButton";
            this.uPrintButton.Size = new System.Drawing.Size(178, 48);
            this.uPrintButton.TabIndex = 18;
            this.uPrintButton.Text = "Print";
            this.uPrintButton.UseVisualStyleBackColor = false;
            this.uPrintButton.Click += new System.EventHandler(this.uEditButton_Click);
            // 
            // uSaveButton
            // 
            this.uSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.uSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.uSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uSaveButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uSaveButton.ForeColor = System.Drawing.Color.White;
            this.uSaveButton.Location = new System.Drawing.Point(16, 265);
            this.uSaveButton.Name = "uSaveButton";
            this.uSaveButton.Size = new System.Drawing.Size(178, 48);
            this.uSaveButton.TabIndex = 17;
            this.uSaveButton.Text = "Add To Bill";
            this.uSaveButton.UseVisualStyleBackColor = false;
            this.uSaveButton.Click += new System.EventHandler(this.uSaveButton_Click);
            // 
            // bQuantityTextBox
            // 
            this.bQuantityTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bQuantityTextBox.Location = new System.Drawing.Point(181, 127);
            this.bQuantityTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.bQuantityTextBox.Multiline = true;
            this.bQuantityTextBox.Name = "bQuantityTextBox";
            this.bQuantityTextBox.Size = new System.Drawing.Size(119, 36);
            this.bQuantityTextBox.TabIndex = 10;
            // 
            // exitLabel
            // 
            this.exitLabel.AutoSize = true;
            this.exitLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitLabel.ForeColor = System.Drawing.Color.Black;
            this.exitLabel.Location = new System.Drawing.Point(787, 2);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(44, 37);
            this.exitLabel.TabIndex = 9;
            this.exitLabel.Text = "╳";
            this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Book Name";
            // 
            // bTitleTextBox
            // 
            this.bTitleTextBox.Enabled = false;
            this.bTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bTitleTextBox.Location = new System.Drawing.Point(16, 127);
            this.bTitleTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.bTitleTextBox.Multiline = true;
            this.bTitleTextBox.Name = "bTitleTextBox";
            this.bTitleTextBox.Size = new System.Drawing.Size(155, 36);
            this.bTitleTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(323, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Shop";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.usernameLabel);
            this.panel2.Controls.Add(this.totalLabel);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.billDataGridView);
            this.panel2.Controls.Add(this.bPriceTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.clientNameTextBox);
            this.panel2.Controls.Add(this.booksDataGridView);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.uResetButton);
            this.panel2.Controls.Add(this.uPrintButton);
            this.panel2.Controls.Add(this.uSaveButton);
            this.panel2.Controls.Add(this.bQuantityTextBox);
            this.panel2.Controls.Add(this.exitLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bTitleTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(248, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 680);
            this.panel2.TabIndex = 7;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.usernameLabel.Location = new System.Drawing.Point(16, 23);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(136, 37);
            this.usernameLabel.TabIndex = 31;
            this.usernameLabel.Text = "Username";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.ForeColor = System.Drawing.Color.Black;
            this.totalLabel.Location = new System.Drawing.Point(595, 560);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(74, 37);
            this.totalLabel.TabIndex = 30;
            this.totalLabel.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(605, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 37);
            this.label7.TabIndex = 29;
            this.label7.Text = "Bill";
            // 
            // billDataGridView
            // 
            this.billDataGridView.AllowUserToAddRows = false;
            this.billDataGridView.AllowUserToDeleteRows = false;
            this.billDataGridView.AllowUserToResizeColumns = false;
            this.billDataGridView.AllowUserToResizeRows = false;
            this.billDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.billDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.billDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.billDataGridView.Location = new System.Drawing.Point(441, 127);
            this.billDataGridView.Name = "billDataGridView";
            this.billDataGridView.RowHeadersVisible = false;
            this.billDataGridView.RowTemplate.Height = 25;
            this.billDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billDataGridView.Size = new System.Drawing.Size(380, 283);
            this.billDataGridView.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Books";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // bPriceTextBox
            // 
            this.bPriceTextBox.Enabled = false;
            this.bPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPriceTextBox.Location = new System.Drawing.Point(181, 210);
            this.bPriceTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.bPriceTextBox.Multiline = true;
            this.bPriceTextBox.Name = "bPriceTextBox";
            this.bPriceTextBox.Size = new System.Drawing.Size(119, 36);
            this.bPriceTextBox.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(181, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 37);
            this.label5.TabIndex = 26;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(16, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 37);
            this.label6.TabIndex = 25;
            this.label6.Text = "Client Name";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientNameTextBox.Location = new System.Drawing.Point(16, 210);
            this.clientNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.clientNameTextBox.Multiline = true;
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(155, 36);
            this.clientNameTextBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(181, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1100, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label8;
        private Label label4;
        private Panel panel6;
        private Panel panel1;
        private DataGridView booksDataGridView;
        private Label label12;
        private Button uResetButton;
        private Button uPrintButton;
        private Button uSaveButton;
        private TextBox bQuantityTextBox;
        private Label exitLabel;
        private Label label1;
        private TextBox bTitleTextBox;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label7;
        private DataGridView billDataGridView;
        private DataGridViewTextBoxColumn Column1;
        private TextBox bPriceTextBox;
        private Label label5;
        private Label label6;
        private TextBox clientNameTextBox;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label totalLabel;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label usernameLabel;
    }
}