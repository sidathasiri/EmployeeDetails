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
            this.insert = new System.Windows.Forms.TabPage();
            this.update = new System.Windows.Forms.TabPage();
            this.delete = new System.Windows.Forms.TabPage();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.search.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(362, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(179, 25);
            this.title.TabIndex = 0;
            this.title.Text = "Employee Details";
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
            this.tabControl1.Size = new System.Drawing.Size(907, 401);
            this.tabControl1.TabIndex = 1;
            // 
            // search
            // 
            this.search.Controls.Add(this.searchButton);
            this.search.Controls.Add(this.id);
            this.search.Controls.Add(this.idTextBox);
            this.search.Location = new System.Drawing.Point(4, 22);
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(3);
            this.search.Size = new System.Drawing.Size(899, 375);
            this.search.TabIndex = 0;
            this.search.Text = "Search Data";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(4, 22);
            this.insert.Name = "insert";
            this.insert.Padding = new System.Windows.Forms.Padding(3);
            this.insert.Size = new System.Drawing.Size(899, 375);
            this.insert.TabIndex = 1;
            this.insert.Text = "Add Employee";
            this.insert.UseVisualStyleBackColor = true;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(4, 22);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(899, 375);
            this.update.TabIndex = 2;
            this.update.Text = "Update Details";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(4, 22);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(899, 375);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete Employee";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(77, 27);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(25, 30);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(49, 13);
            this.id.TabIndex = 1;
            this.id.Text = "Enter ID:";
            this.id.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(204, 27);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 489);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
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
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}

