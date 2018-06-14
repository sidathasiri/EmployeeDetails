namespace EmployeeDetails
{
    partial class Form1
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
            this.title = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.search = new System.Windows.Forms.TabPage();
            this.searchResults = new System.Windows.Forms.DataGridView();
            this.searchLastNameTextBox = new System.Windows.Forms.TextBox();
            this.searchLastNameLabel = new System.Windows.Forms.Label();
            this.searchFirstNametextBox = new System.Windows.Forms.TextBox();
            this.searchFirstNamelabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchIdLabel = new System.Windows.Forms.Label();
            this.searchIdTextBox = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.TabPage();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.departmntComboBox = new System.Windows.Forms.ComboBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.addressLine3 = new System.Windows.Forms.TextBox();
            this.addressLine2 = new System.Windows.Forms.TextBox();
            this.addressLine1 = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.genderLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.enterDetailsLabel = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.TabPage();
            this.updateFindLabel = new System.Windows.Forms.Label();
            this.updateDataGridView = new System.Windows.Forms.DataGridView();
            this.updateIdTextBox = new System.Windows.Forms.TextBox();
            this.updateFindButton = new System.Windows.Forms.Button();
            this.updateIdlabel = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.TabPage();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteFindLabel = new System.Windows.Forms.Label();
            this.deleteDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteFindButton = new System.Windows.Forms.Button();
            this.deleteIdtextBox = new System.Windows.Forms.TextBox();
            this.deleteIdLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResults)).BeginInit();
            this.insert.SuspendLayout();
            this.update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateDataGridView)).BeginInit();
            this.delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(340, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(310, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Employee Details Management";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.search);
            this.tabControl1.Controls.Add(this.insert);
            this.tabControl1.Controls.Add(this.update);
            this.tabControl1.Controls.Add(this.delete);
            this.tabControl1.Location = new System.Drawing.Point(12, 78);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(907, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // search
            // 
            this.search.Controls.Add(this.searchResults);
            this.search.Controls.Add(this.searchLastNameTextBox);
            this.search.Controls.Add(this.searchLastNameLabel);
            this.search.Controls.Add(this.searchFirstNametextBox);
            this.search.Controls.Add(this.searchFirstNamelabel);
            this.search.Controls.Add(this.resultLabel);
            this.search.Controls.Add(this.searchButton);
            this.search.Controls.Add(this.searchIdLabel);
            this.search.Controls.Add(this.searchIdTextBox);
            this.search.Location = new System.Drawing.Point(4, 22);
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(3);
            this.search.Size = new System.Drawing.Size(899, 424);
            this.search.TabIndex = 0;
            this.search.Text = "Search Data";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchResults
            // 
            this.searchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResults.Location = new System.Drawing.Point(28, 139);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(839, 265);
            this.searchResults.TabIndex = 8;
            // 
            // searchLastNameTextBox
            // 
            this.searchLastNameTextBox.Location = new System.Drawing.Point(285, 61);
            this.searchLastNameTextBox.Name = "searchLastNameTextBox";
            this.searchLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchLastNameTextBox.TabIndex = 7;
            // 
            // searchLastNameLabel
            // 
            this.searchLastNameLabel.AutoSize = true;
            this.searchLastNameLabel.Location = new System.Drawing.Point(218, 64);
            this.searchLastNameLabel.Name = "searchLastNameLabel";
            this.searchLastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.searchLastNameLabel.TabIndex = 6;
            this.searchLastNameLabel.Text = "Last Name:";
            // 
            // searchFirstNametextBox
            // 
            this.searchFirstNametextBox.Location = new System.Drawing.Point(95, 64);
            this.searchFirstNametextBox.Name = "searchFirstNametextBox";
            this.searchFirstNametextBox.Size = new System.Drawing.Size(100, 20);
            this.searchFirstNametextBox.TabIndex = 5;
            // 
            // searchFirstNamelabel
            // 
            this.searchFirstNamelabel.AutoSize = true;
            this.searchFirstNamelabel.Location = new System.Drawing.Point(25, 64);
            this.searchFirstNamelabel.Name = "searchFirstNamelabel";
            this.searchFirstNamelabel.Size = new System.Drawing.Size(60, 13);
            this.searchFirstNamelabel.TabIndex = 4;
            this.searchFirstNamelabel.Text = "First Name:";
            this.searchFirstNamelabel.Click += new System.EventHandler(this.searchFirstNamelabel_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(24, 105);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(70, 20);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Results";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(403, 59);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchIdLabel
            // 
            this.searchIdLabel.AutoSize = true;
            this.searchIdLabel.Location = new System.Drawing.Point(25, 30);
            this.searchIdLabel.Name = "searchIdLabel";
            this.searchIdLabel.Size = new System.Drawing.Size(49, 13);
            this.searchIdLabel.TabIndex = 1;
            this.searchIdLabel.Text = "Enter ID:";
            this.searchIdLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // searchIdTextBox
            // 
            this.searchIdTextBox.Location = new System.Drawing.Point(95, 27);
            this.searchIdTextBox.Name = "searchIdTextBox";
            this.searchIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchIdTextBox.TabIndex = 0;
            // 
            // insert
            // 
            this.insert.Controls.Add(this.FemaleRadioButton);
            this.insert.Controls.Add(this.submitButton);
            this.insert.Controls.Add(this.departmntComboBox);
            this.insert.Controls.Add(this.departmentLabel);
            this.insert.Controls.Add(this.addressLine3);
            this.insert.Controls.Add(this.addressLine2);
            this.insert.Controls.Add(this.addressLine1);
            this.insert.Controls.Add(this.addressLabel);
            this.insert.Controls.Add(this.emailTextBox);
            this.insert.Controls.Add(this.emailLabel);
            this.insert.Controls.Add(this.mobileTextBox);
            this.insert.Controls.Add(this.mobileLabel);
            this.insert.Controls.Add(this.maleRadioButton);
            this.insert.Controls.Add(this.genderLabel);
            this.insert.Controls.Add(this.ageTextBox);
            this.insert.Controls.Add(this.ageLabel);
            this.insert.Controls.Add(this.lastNameTextBox);
            this.insert.Controls.Add(this.lastNameLabel);
            this.insert.Controls.Add(this.firstNameTextBox);
            this.insert.Controls.Add(this.firstNameLabel);
            this.insert.Controls.Add(this.enterDetailsLabel);
            this.insert.Location = new System.Drawing.Point(4, 22);
            this.insert.Name = "insert";
            this.insert.Padding = new System.Windows.Forms.Padding(3);
            this.insert.Size = new System.Drawing.Size(899, 424);
            this.insert.TabIndex = 1;
            this.insert.Text = "Add Employee";
            this.insert.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(423, 92);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleRadioButton.TabIndex = 21;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(381, 275);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // departmntComboBox
            // 
            this.departmntComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.departmntComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departmntComboBox.FormattingEnabled = true;
            this.departmntComboBox.Items.AddRange(new object[] {
            "Transport",
            "Management",
            "Marketing",
            "Finance",
            "Technical",
            "Sales"});
            this.departmntComboBox.Location = new System.Drawing.Point(360, 170);
            this.departmntComboBox.Name = "departmntComboBox";
            this.departmntComboBox.Size = new System.Drawing.Size(121, 21);
            this.departmntComboBox.TabIndex = 19;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(288, 175);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(65, 13);
            this.departmentLabel.TabIndex = 18;
            this.departmentLabel.Text = "Department:";
            this.departmentLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // addressLine3
            // 
            this.addressLine3.Location = new System.Drawing.Point(91, 226);
            this.addressLine3.Name = "addressLine3";
            this.addressLine3.Size = new System.Drawing.Size(100, 20);
            this.addressLine3.TabIndex = 17;
            // 
            // addressLine2
            // 
            this.addressLine2.Location = new System.Drawing.Point(91, 199);
            this.addressLine2.Name = "addressLine2";
            this.addressLine2.Size = new System.Drawing.Size(100, 20);
            this.addressLine2.TabIndex = 16;
            // 
            // addressLine1
            // 
            this.addressLine1.Location = new System.Drawing.Point(91, 172);
            this.addressLine1.Name = "addressLine1";
            this.addressLine1.Size = new System.Drawing.Size(100, 20);
            this.addressLine1.TabIndex = 15;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(33, 172);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "Address";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(360, 132);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(288, 132);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Email:";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(91, 126);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(100, 20);
            this.mobileTextBox.TabIndex = 11;
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Location = new System.Drawing.Point(30, 126);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(41, 13);
            this.mobileLabel.TabIndex = 10;
            this.mobileLabel.Text = "Mobile:";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(360, 92);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 8;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(288, 92);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(45, 13);
            this.genderLabel.TabIndex = 7;
            this.genderLabel.Text = "Gender:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(91, 89);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 6;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(27, 89);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(29, 13);
            this.ageLabel.TabIndex = 5;
            this.ageLabel.Text = "Age:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(360, 60);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(288, 60);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(91, 54);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(24, 54);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name:";
            // 
            // enterDetailsLabel
            // 
            this.enterDetailsLabel.AutoSize = true;
            this.enterDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterDetailsLabel.Location = new System.Drawing.Point(20, 19);
            this.enterDetailsLabel.Name = "enterDetailsLabel";
            this.enterDetailsLabel.Size = new System.Drawing.Size(111, 20);
            this.enterDetailsLabel.TabIndex = 0;
            this.enterDetailsLabel.Text = "Enter details";
            // 
            // update
            // 
            this.update.Controls.Add(this.updateFindLabel);
            this.update.Controls.Add(this.updateDataGridView);
            this.update.Controls.Add(this.updateIdTextBox);
            this.update.Controls.Add(this.updateFindButton);
            this.update.Controls.Add(this.updateIdlabel);
            this.update.Location = new System.Drawing.Point(4, 22);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(899, 424);
            this.update.TabIndex = 2;
            this.update.Text = "Update Details";
            this.update.UseVisualStyleBackColor = true;
            // 
            // updateFindLabel
            // 
            this.updateFindLabel.AutoSize = true;
            this.updateFindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateFindLabel.Location = new System.Drawing.Point(30, 63);
            this.updateFindLabel.Name = "updateFindLabel";
            this.updateFindLabel.Size = new System.Drawing.Size(77, 13);
            this.updateFindLabel.TabIndex = 4;
            this.updateFindLabel.Text = "Find Results";
            // 
            // updateDataGridView
            // 
            this.updateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateDataGridView.Location = new System.Drawing.Point(30, 88);
            this.updateDataGridView.Name = "updateDataGridView";
            this.updateDataGridView.Size = new System.Drawing.Size(830, 111);
            this.updateDataGridView.TabIndex = 3;
            // 
            // updateIdTextBox
            // 
            this.updateIdTextBox.Location = new System.Drawing.Point(104, 25);
            this.updateIdTextBox.Name = "updateIdTextBox";
            this.updateIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateIdTextBox.TabIndex = 2;
            // 
            // updateFindButton
            // 
            this.updateFindButton.Location = new System.Drawing.Point(219, 25);
            this.updateFindButton.Name = "updateFindButton";
            this.updateFindButton.Size = new System.Drawing.Size(75, 23);
            this.updateFindButton.TabIndex = 1;
            this.updateFindButton.Text = "Find";
            this.updateFindButton.UseVisualStyleBackColor = true;
            // 
            // updateIdlabel
            // 
            this.updateIdlabel.AutoSize = true;
            this.updateIdlabel.Location = new System.Drawing.Point(27, 25);
            this.updateIdlabel.Name = "updateIdlabel";
            this.updateIdlabel.Size = new System.Drawing.Size(70, 13);
            this.updateIdlabel.TabIndex = 0;
            this.updateIdlabel.Text = "Employee ID:";
            // 
            // delete
            // 
            this.delete.Controls.Add(this.deleteButton);
            this.delete.Controls.Add(this.deleteFindLabel);
            this.delete.Controls.Add(this.deleteDataGridView);
            this.delete.Controls.Add(this.deleteFindButton);
            this.delete.Controls.Add(this.deleteIdtextBox);
            this.delete.Controls.Add(this.deleteIdLabel);
            this.delete.Location = new System.Drawing.Point(4, 22);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(899, 424);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete Employee";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(791, 216);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // deleteFindLabel
            // 
            this.deleteFindLabel.AutoSize = true;
            this.deleteFindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFindLabel.Location = new System.Drawing.Point(36, 64);
            this.deleteFindLabel.Name = "deleteFindLabel";
            this.deleteFindLabel.Size = new System.Drawing.Size(77, 13);
            this.deleteFindLabel.TabIndex = 4;
            this.deleteFindLabel.Text = "Find Results";
            // 
            // deleteDataGridView
            // 
            this.deleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteDataGridView.Location = new System.Drawing.Point(36, 90);
            this.deleteDataGridView.Name = "deleteDataGridView";
            this.deleteDataGridView.Size = new System.Drawing.Size(828, 104);
            this.deleteDataGridView.TabIndex = 3;
            // 
            // deleteFindButton
            // 
            this.deleteFindButton.Location = new System.Drawing.Point(236, 21);
            this.deleteFindButton.Name = "deleteFindButton";
            this.deleteFindButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFindButton.TabIndex = 2;
            this.deleteFindButton.Text = "Find";
            this.deleteFindButton.UseVisualStyleBackColor = true;
            // 
            // deleteIdtextBox
            // 
            this.deleteIdtextBox.Location = new System.Drawing.Point(104, 22);
            this.deleteIdtextBox.Name = "deleteIdtextBox";
            this.deleteIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.deleteIdtextBox.TabIndex = 1;
            // 
            // deleteIdLabel
            // 
            this.deleteIdLabel.AutoSize = true;
            this.deleteIdLabel.Location = new System.Drawing.Point(33, 25);
            this.deleteIdLabel.Name = "deleteIdLabel";
            this.deleteIdLabel.Size = new System.Drawing.Size(64, 13);
            this.deleteIdLabel.TabIndex = 0;
            this.deleteIdLabel.Text = "Employe ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 543);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResults)).EndInit();
            this.insert.ResumeLayout(false);
            this.insert.PerformLayout();
            this.update.ResumeLayout(false);
            this.update.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateDataGridView)).EndInit();
            this.delete.ResumeLayout(false);
            this.delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage search;
        private System.Windows.Forms.TabPage insert;
        private System.Windows.Forms.TabPage update;
        private System.Windows.Forms.TabPage delete;
        private System.Windows.Forms.Label searchIdLabel;
        private System.Windows.Forms.TextBox searchIdTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.TextBox addressLine3;
        private System.Windows.Forms.TextBox addressLine2;
        private System.Windows.Forms.TextBox addressLine1;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label enterDetailsLabel;
        private System.Windows.Forms.ComboBox departmntComboBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox updateIdTextBox;
        private System.Windows.Forms.Button updateFindButton;
        private System.Windows.Forms.Label updateIdlabel;
        private System.Windows.Forms.Label deleteIdLabel;
        private System.Windows.Forms.Button deleteFindButton;
        private System.Windows.Forms.TextBox deleteIdtextBox;
        private System.Windows.Forms.Label updateFindLabel;
        private System.Windows.Forms.DataGridView updateDataGridView;
        private System.Windows.Forms.Label deleteFindLabel;
        private System.Windows.Forms.DataGridView deleteDataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox searchLastNameTextBox;
        private System.Windows.Forms.Label searchLastNameLabel;
        private System.Windows.Forms.TextBox searchFirstNametextBox;
        private System.Windows.Forms.Label searchFirstNamelabel;
        private System.Windows.Forms.DataGridView searchResults;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
    }
}

