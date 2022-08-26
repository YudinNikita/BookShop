namespace BookShop
{
    partial class Books
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.bFilterComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.resetButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.bPriceTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bQuantityTextBox = new System.Windows.Forms.TextBox();
            this.bCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bAuthorTextBox = new System.Windows.Forms.TextBox();
            this.exitLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bTitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dashBoardPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.usersPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.booksPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.dashBoardPanel.SuspendLayout();
            this.usersPanel.SuspendLayout();
            this.booksPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.refreshButton);
            this.panel2.Controls.Add(this.bFilterComboBox);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.booksDataGridView);
            this.panel2.Controls.Add(this.resetButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.editButton);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.bPriceTextBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.bQuantityTextBox);
            this.panel2.Controls.Add(this.bCategoryComboBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.bAuthorTextBox);
            this.panel2.Controls.Add(this.exitLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bTitleTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(248, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 680);
            this.panel2.TabIndex = 3;
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.refreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(525, 284);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(143, 36);
            this.refreshButton.TabIndex = 24;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // bFilterComboBox
            // 
            this.bFilterComboBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bFilterComboBox.FormattingEnabled = true;
            this.bFilterComboBox.Items.AddRange(new object[] {
            "Programming",
            "Networking",
            "Math",
            "Physics",
            "Novels",
            "Biography"});
            this.bFilterComboBox.Location = new System.Drawing.Point(337, 284);
            this.bFilterComboBox.Name = "bFilterComboBox";
            this.bFilterComboBox.Size = new System.Drawing.Size(182, 36);
            this.bFilterComboBox.TabIndex = 23;
            this.bFilterComboBox.Text = "Filter By Category";
            this.bFilterComboBox.SelectionChangeCommitted += new System.EventHandler(this.FilterComboBox_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(360, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 37);
            this.label12.TabIndex = 22;
            this.label12.Text = "Book List";
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
            this.booksDataGridView.Location = new System.Drawing.Point(16, 326);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.RowHeadersVisible = false;
            this.booksDataGridView.RowTemplate.Height = 25;
            this.booksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDataGridView.Size = new System.Drawing.Size(812, 342);
            this.booksDataGridView.TabIndex = 21;
            this.booksDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDataGridView_CellDoubleClick);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.resetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(595, 192);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(178, 48);
            this.resetButton.TabIndex = 20;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(411, 192);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(178, 48);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(225, 192);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(178, 48);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(37, 192);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(178, 48);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // bPriceTextBox
            // 
            this.bPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bPriceTextBox.Location = new System.Drawing.Point(696, 127);
            this.bPriceTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.bPriceTextBox.Multiline = true;
            this.bPriceTextBox.Name = "bPriceTextBox";
            this.bPriceTextBox.Size = new System.Drawing.Size(132, 36);
            this.bPriceTextBox.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(696, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 37);
            this.label10.TabIndex = 15;
            this.label10.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(567, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 37);
            this.label11.TabIndex = 14;
            this.label11.Text = "Quantity";
            // 
            // bQuantityTextBox
            // 
            this.bQuantityTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bQuantityTextBox.Location = new System.Drawing.Point(567, 127);
            this.bQuantityTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.bQuantityTextBox.Multiline = true;
            this.bQuantityTextBox.Name = "bQuantityTextBox";
            this.bQuantityTextBox.Size = new System.Drawing.Size(119, 36);
            this.bQuantityTextBox.TabIndex = 13;
            // 
            // bCategoryComboBox
            // 
            this.bCategoryComboBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bCategoryComboBox.FormattingEnabled = true;
            this.bCategoryComboBox.Items.AddRange(new object[] {
            "Programming",
            "Networking",
            "Math",
            "Physics",
            "Novels",
            "Biography"});
            this.bCategoryComboBox.Location = new System.Drawing.Point(390, 127);
            this.bCategoryComboBox.Name = "bCategoryComboBox";
            this.bCategoryComboBox.Size = new System.Drawing.Size(169, 36);
            this.bCategoryComboBox.TabIndex = 12;
            this.bCategoryComboBox.Text = "Select Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(390, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 37);
            this.label9.TabIndex = 11;
            this.label9.Text = "Categories";
            // 
            // bAuthorTextBox
            // 
            this.bAuthorTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bAuthorTextBox.Location = new System.Drawing.Point(204, 127);
            this.bAuthorTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.bAuthorTextBox.Multiline = true;
            this.bAuthorTextBox.Name = "bAuthorTextBox";
            this.bAuthorTextBox.Size = new System.Drawing.Size(178, 36);
            this.bAuthorTextBox.TabIndex = 10;
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
            this.exitLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(204, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Book Title";
            // 
            // bTitleTextBox
            // 
            this.bTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bTitleTextBox.Location = new System.Drawing.Point(16, 127);
            this.bTitleTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.bTitleTextBox.Multiline = true;
            this.bTitleTextBox.Name = "bTitleTextBox";
            this.bTitleTextBox.Size = new System.Drawing.Size(178, 36);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dashBoardPanel);
            this.panel1.Controls.Add(this.usersPanel);
            this.panel1.Controls.Add(this.booksPanel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 680);
            this.panel1.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Purple;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(12, 600);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(218, 56);
            this.panel6.TabIndex = 14;
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
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
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
            // dashBoardPanel
            // 
            this.dashBoardPanel.BackColor = System.Drawing.Color.Purple;
            this.dashBoardPanel.Controls.Add(this.label7);
            this.dashBoardPanel.Location = new System.Drawing.Point(12, 225);
            this.dashBoardPanel.Name = "dashBoardPanel";
            this.dashBoardPanel.Padding = new System.Windows.Forms.Padding(5);
            this.dashBoardPanel.Size = new System.Drawing.Size(218, 56);
            this.dashBoardPanel.TabIndex = 12;
            this.dashBoardPanel.Click += new System.EventHandler(this.dashboardPanel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 46);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dashboard";
            this.label7.Click += new System.EventHandler(this.dashboardPanel_Click);
            // 
            // usersPanel
            // 
            this.usersPanel.BackColor = System.Drawing.Color.Purple;
            this.usersPanel.Controls.Add(this.label6);
            this.usersPanel.Location = new System.Drawing.Point(12, 163);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Padding = new System.Windows.Forms.Padding(5);
            this.usersPanel.Size = new System.Drawing.Size(218, 56);
            this.usersPanel.TabIndex = 11;
            this.usersPanel.Click += new System.EventHandler(this.usersPanel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(60, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 46);
            this.label6.TabIndex = 10;
            this.label6.Text = "Users";
            this.label6.Click += new System.EventHandler(this.usersPanel_Click);
            // 
            // booksPanel
            // 
            this.booksPanel.BackColor = System.Drawing.Color.Fuchsia;
            this.booksPanel.Controls.Add(this.label5);
            this.booksPanel.Location = new System.Drawing.Point(12, 101);
            this.booksPanel.Name = "booksPanel";
            this.booksPanel.Padding = new System.Windows.Forms.Padding(5);
            this.booksPanel.Size = new System.Drawing.Size(218, 56);
            this.booksPanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(60, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 46);
            this.label5.TabIndex = 10;
            this.label5.Text = "Books";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1100, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.dashBoardPanel.ResumeLayout(false);
            this.dashBoardPanel.PerformLayout();
            this.usersPanel.ResumeLayout(false);
            this.usersPanel.PerformLayout();
            this.booksPanel.ResumeLayout(false);
            this.booksPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label exitLabel;
        private Label label3;
        private Label label1;
        private TextBox bTitleTextBox;
        private Label label2;
        private Panel panel1;
        private ComboBox bCategoryComboBox;
        private Label label9;
        private TextBox bAuthorTextBox;
        private Label label8;
        private Panel dashBoardPanel;
        private Label label7;
        private Panel usersPanel;
        private Label label6;
        private Panel booksPanel;
        private Label label5;
        private Button refreshButton;
        private ComboBox bFilterComboBox;
        private Label label12;
        private DataGridView booksDataGridView;
        private Button resetButton;
        private Button deleteButton;
        private Button editButton;
        private Button saveButton;
        private TextBox bPriceTextBox;
        private Label label10;
        private Label label11;
        private TextBox bQuantityTextBox;
        private Panel panel6;
        private Label label4;
    }
}