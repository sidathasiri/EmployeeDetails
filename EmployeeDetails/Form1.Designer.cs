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
            this.updateButton = new System.Windows.Forms.Button();
            this.updateFemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.updateDeptComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateAdd3TextBox = new System.Windows.Forms.TextBox();
            this.updateAdd2TextBox = new System.Windows.Forms.TextBox();
            this.updateAdd1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updateEmailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateMobileTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateMaleRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.updateAgeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updateLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.updateFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResults)).BeginInit();
            this.insert.SuspendLayout();
            this.update.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateDataGridView)).BeginInit();
            this.delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.tabControl1.Size = new System.Drawing.Size(907, 510);
            this.tabControl1.TabIndex = 1;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Gainsboro;
            this.search.Controls.Add(this.pictureBox1);
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
            this.search.Size = new System.Drawing.Size(899, 484);
            this.search.TabIndex = 0;
            this.search.Text = "Search Data";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchResults
            // 
            this.searchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResults.Location = new System.Drawing.Point(28, 139);
            this.searchResults.Name = "searchResults";
            this.searchResults.ReadOnly = true;
            this.searchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.searchButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.searchButton.Location = new System.Drawing.Point(403, 59);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
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
            this.insert.BackColor = System.Drawing.Color.Gainsboro;
            this.insert.Controls.Add(this.pictureBox2);
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
            this.insert.Size = new System.Drawing.Size(899, 484);
            this.insert.TabIndex = 1;
            this.insert.Text = "Add Employee";
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
            this.submitButton.BackColor = System.Drawing.Color.LimeGreen;
            this.submitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitButton.Location = new System.Drawing.Point(360, 226);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(111, 34);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
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
            this.mobileTextBox.TextChanged += new System.EventHandler(this.mobileTextBox_TextChanged);
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
            this.ageTextBox.TextChanged += new System.EventHandler(this.ageTextBox_TextChanged);
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
            this.update.BackColor = System.Drawing.Color.Gainsboro;
            this.update.Controls.Add(this.pictureBox3);
            this.update.Controls.Add(this.updateButton);
            this.update.Controls.Add(this.updateFemaleRadioButton);
            this.update.Controls.Add(this.updateDeptComboBox);
            this.update.Controls.Add(this.label1);
            this.update.Controls.Add(this.updateAdd3TextBox);
            this.update.Controls.Add(this.updateAdd2TextBox);
            this.update.Controls.Add(this.updateAdd1TextBox);
            this.update.Controls.Add(this.label2);
            this.update.Controls.Add(this.updateEmailTextBox);
            this.update.Controls.Add(this.label3);
            this.update.Controls.Add(this.updateMobileTextBox);
            this.update.Controls.Add(this.label4);
            this.update.Controls.Add(this.updateMaleRadioButton);
            this.update.Controls.Add(this.label5);
            this.update.Controls.Add(this.updateAgeTextBox);
            this.update.Controls.Add(this.label6);
            this.update.Controls.Add(this.updateLastNameTextBox);
            this.update.Controls.Add(this.label7);
            this.update.Controls.Add(this.updateFirstNameTextBox);
            this.update.Controls.Add(this.label8);
            this.update.Controls.Add(this.updateFindLabel);
            this.update.Controls.Add(this.updateDataGridView);
            this.update.Controls.Add(this.updateIdTextBox);
            this.update.Controls.Add(this.updateFindButton);
            this.update.Controls.Add(this.updateIdlabel);
            this.update.Location = new System.Drawing.Point(4, 22);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(899, 484);
            this.update.TabIndex = 2;
            this.update.Text = "Update Details";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.LimeGreen;
            this.updateButton.Location = new System.Drawing.Point(381, 429);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(97, 32);
            this.updateButton.TabIndex = 41;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateFemaleRadioButton
            // 
            this.updateFemaleRadioButton.AutoSize = true;
            this.updateFemaleRadioButton.Location = new System.Drawing.Point(429, 299);
            this.updateFemaleRadioButton.Name = "updateFemaleRadioButton";
            this.updateFemaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.updateFemaleRadioButton.TabIndex = 40;
            this.updateFemaleRadioButton.TabStop = true;
            this.updateFemaleRadioButton.Text = "Female";
            this.updateFemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // updateDeptComboBox
            // 
            this.updateDeptComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.updateDeptComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.updateDeptComboBox.FormattingEnabled = true;
            this.updateDeptComboBox.Items.AddRange(new object[] {
            "Transport",
            "Management",
            "Marketing",
            "Finance",
            "Technical",
            "Sales"});
            this.updateDeptComboBox.Location = new System.Drawing.Point(366, 377);
            this.updateDeptComboBox.Name = "updateDeptComboBox";
            this.updateDeptComboBox.Size = new System.Drawing.Size(121, 21);
            this.updateDeptComboBox.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Department:";
            // 
            // updateAdd3TextBox
            // 
            this.updateAdd3TextBox.Location = new System.Drawing.Point(97, 433);
            this.updateAdd3TextBox.Name = "updateAdd3TextBox";
            this.updateAdd3TextBox.Size = new System.Drawing.Size(100, 20);
            this.updateAdd3TextBox.TabIndex = 37;
            // 
            // updateAdd2TextBox
            // 
            this.updateAdd2TextBox.Location = new System.Drawing.Point(97, 406);
            this.updateAdd2TextBox.Name = "updateAdd2TextBox";
            this.updateAdd2TextBox.Size = new System.Drawing.Size(100, 20);
            this.updateAdd2TextBox.TabIndex = 36;
            // 
            // updateAdd1TextBox
            // 
            this.updateAdd1TextBox.Location = new System.Drawing.Point(97, 379);
            this.updateAdd1TextBox.Name = "updateAdd1TextBox";
            this.updateAdd1TextBox.Size = new System.Drawing.Size(100, 20);
            this.updateAdd1TextBox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Address";
            // 
            // updateEmailTextBox
            // 
            this.updateEmailTextBox.Location = new System.Drawing.Point(366, 339);
            this.updateEmailTextBox.Name = "updateEmailTextBox";
            this.updateEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateEmailTextBox.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Email:";
            // 
            // updateMobileTextBox
            // 
            this.updateMobileTextBox.Location = new System.Drawing.Point(97, 333);
            this.updateMobileTextBox.Name = "updateMobileTextBox";
            this.updateMobileTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateMobileTextBox.TabIndex = 31;
            this.updateMobileTextBox.TextChanged += new System.EventHandler(this.updateMobileTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mobile:";
            // 
            // updateMaleRadioButton
            // 
            this.updateMaleRadioButton.AutoSize = true;
            this.updateMaleRadioButton.Location = new System.Drawing.Point(366, 299);
            this.updateMaleRadioButton.Name = "updateMaleRadioButton";
            this.updateMaleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.updateMaleRadioButton.TabIndex = 29;
            this.updateMaleRadioButton.TabStop = true;
            this.updateMaleRadioButton.Text = "Male";
            this.updateMaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Gender:";
            // 
            // updateAgeTextBox
            // 
            this.updateAgeTextBox.Location = new System.Drawing.Point(97, 296);
            this.updateAgeTextBox.Name = "updateAgeTextBox";
            this.updateAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateAgeTextBox.TabIndex = 27;
            this.updateAgeTextBox.TextChanged += new System.EventHandler(this.updateAgeTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Age:";
            // 
            // updateLastNameTextBox
            // 
            this.updateLastNameTextBox.Location = new System.Drawing.Point(366, 267);
            this.updateLastNameTextBox.Name = "updateLastNameTextBox";
            this.updateLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateLastNameTextBox.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Last Name:";
            // 
            // updateFirstNameTextBox
            // 
            this.updateFirstNameTextBox.Location = new System.Drawing.Point(97, 261);
            this.updateFirstNameTextBox.Name = "updateFirstNameTextBox";
            this.updateFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateFirstNameTextBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "First Name:";
            // 
            // updateFindLabel
            // 
            this.updateFindLabel.AutoSize = true;
            this.updateFindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateFindLabel.Location = new System.Drawing.Point(30, 95);
            this.updateFindLabel.Name = "updateFindLabel";
            this.updateFindLabel.Size = new System.Drawing.Size(49, 13);
            this.updateFindLabel.TabIndex = 4;
            this.updateFindLabel.Text = "Results";
            // 
            // updateDataGridView
            // 
            this.updateDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.updateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.updateDataGridView.Location = new System.Drawing.Point(30, 122);
            this.updateDataGridView.Name = "updateDataGridView";
            this.updateDataGridView.ReadOnly = true;
            this.updateDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.updateDataGridView.Size = new System.Drawing.Size(830, 120);
            this.updateDataGridView.TabIndex = 3;
            this.updateDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.updateDataGridView_MouseClick);
            // 
            // updateIdTextBox
            // 
            this.updateIdTextBox.Location = new System.Drawing.Point(104, 60);
            this.updateIdTextBox.Name = "updateIdTextBox";
            this.updateIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.updateIdTextBox.TabIndex = 2;
            // 
            // updateFindButton
            // 
            this.updateFindButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.updateFindButton.Location = new System.Drawing.Point(219, 58);
            this.updateFindButton.Name = "updateFindButton";
            this.updateFindButton.Size = new System.Drawing.Size(75, 23);
            this.updateFindButton.TabIndex = 1;
            this.updateFindButton.Text = "Search";
            this.updateFindButton.UseVisualStyleBackColor = false;
            this.updateFindButton.Click += new System.EventHandler(this.updateFindButton_Click);
            // 
            // updateIdlabel
            // 
            this.updateIdlabel.AutoSize = true;
            this.updateIdlabel.Location = new System.Drawing.Point(27, 62);
            this.updateIdlabel.Name = "updateIdlabel";
            this.updateIdlabel.Size = new System.Drawing.Size(70, 13);
            this.updateIdlabel.TabIndex = 0;
            this.updateIdlabel.Text = "Employee ID:";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Gainsboro;
            this.delete.Controls.Add(this.pictureBox4);
            this.delete.Controls.Add(this.deleteButton);
            this.delete.Controls.Add(this.deleteFindLabel);
            this.delete.Controls.Add(this.deleteDataGridView);
            this.delete.Controls.Add(this.deleteFindButton);
            this.delete.Controls.Add(this.deleteIdtextBox);
            this.delete.Controls.Add(this.deleteIdLabel);
            this.delete.Location = new System.Drawing.Point(4, 22);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(899, 484);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete Employee";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(761, 430);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 34);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // deleteFindLabel
            // 
            this.deleteFindLabel.AutoSize = true;
            this.deleteFindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFindLabel.Location = new System.Drawing.Point(36, 105);
            this.deleteFindLabel.Name = "deleteFindLabel";
            this.deleteFindLabel.Size = new System.Drawing.Size(49, 13);
            this.deleteFindLabel.TabIndex = 4;
            this.deleteFindLabel.Text = "Results";
            // 
            // deleteDataGridView
            // 
            this.deleteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteDataGridView.Location = new System.Drawing.Point(36, 131);
            this.deleteDataGridView.Name = "deleteDataGridView";
            this.deleteDataGridView.ReadOnly = true;
            this.deleteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deleteDataGridView.Size = new System.Drawing.Size(828, 285);
            this.deleteDataGridView.TabIndex = 3;
            this.deleteDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deleteDataGridView_MouseClick);
            // 
            // deleteFindButton
            // 
            this.deleteFindButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.deleteFindButton.Location = new System.Drawing.Point(238, 69);
            this.deleteFindButton.Name = "deleteFindButton";
            this.deleteFindButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFindButton.TabIndex = 2;
            this.deleteFindButton.Text = "Search";
            this.deleteFindButton.UseVisualStyleBackColor = false;
            this.deleteFindButton.Click += new System.EventHandler(this.deleteFindButton_Click);
            // 
            // deleteIdtextBox
            // 
            this.deleteIdtextBox.Location = new System.Drawing.Point(106, 70);
            this.deleteIdtextBox.Name = "deleteIdtextBox";
            this.deleteIdtextBox.Size = new System.Drawing.Size(100, 20);
            this.deleteIdtextBox.TabIndex = 1;
            // 
            // deleteIdLabel
            // 
            this.deleteIdLabel.AutoSize = true;
            this.deleteIdLabel.Location = new System.Drawing.Point(35, 73);
            this.deleteIdLabel.Name = "deleteIdLabel";
            this.deleteIdLabel.Size = new System.Drawing.Size(64, 13);
            this.deleteIdLabel.TabIndex = 0;
            this.deleteIdLabel.Text = "Employe ID:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::EmployeeDetails.Properties.Resources.add_big;
            this.pictureBox5.Location = new System.Drawing.Point(783, -2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 98);
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeDetails.Properties.Resources.search_big;
            this.pictureBox1.Location = new System.Drawing.Point(649, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 127);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EmployeeDetails.Properties.Resources.employee;
            this.pictureBox2.Location = new System.Drawing.Point(652, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 137);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EmployeeDetails.Properties.Resources.edit_big;
            this.pictureBox3.Location = new System.Drawing.Point(660, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 113);
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::EmployeeDetails.Properties.Resources.delete_big;
            this.pictureBox4.Location = new System.Drawing.Point(687, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(131, 125);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(931, 601);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.RadioButton updateFemaleRadioButton;
        private System.Windows.Forms.ComboBox updateDeptComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox updateAdd3TextBox;
        private System.Windows.Forms.TextBox updateAdd2TextBox;
        private System.Windows.Forms.TextBox updateAdd1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox updateEmailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox updateMobileTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton updateMaleRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox updateAgeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updateLastNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox updateFirstNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

