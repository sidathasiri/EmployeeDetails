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

namespace EmployeeDetails
{
    public partial class Form1 : Form
    {
        EmployeeServices employeeService = new EmployeeServices();
        public Form1()
        {
            InitializeComponent();
            maleRadioButton.Checked = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            searchResults.DataSource = getEmployeeList();
        }

        private DataTable getEmployeeList() {
            DataTable employeeDataTable = new DataTable();
            String query = "SELECT id as 'ID', first_name as 'First Name', last_name as 'Last Name', age as 'Age', gender as 'Gender', mobile as 'Mobile', email as 'Email', address1 as 'Address1', address2 as 'Address2', address3 as 'Address3', department as 'Departmnt' FROM employees";
            employeeDataTable.Load(employeeService.getEmployeeDetailsDataReader(query));
            return employeeDataTable;
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchResults.DataSource = getSearchResults();
        }

        private DataTable getSearchResults() {
            DataTable employeeDataTable = new DataTable();
            String strId = searchIdTextBox.Text;
            String fName = searchFirstNametextBox.Text+"%";
            String lName = searchLastNameTextBox.Text+"%";

            if (strId.Length == 0) {
                strId = "%";
            }
            if (fName.Length == 0) {
                fName = "%";
            }
            if (lName.Length == 0) {
                lName = "%";
            }
            String query = String.Format("SELECT id as 'ID', first_name as 'First Name', last_name as 'Last Name', age as 'Age', gender as 'Gender', mobile as 'Mobile', email as 'Email', address1 as 'Address1', address2 as 'Address2', address3 as 'Address3', department as 'Departmnt' FROM employees WHERE id LIKE '{0}' AND first_name LIKE '{1}' AND last_name LIKE '{2}'", strId, fName, lName);

            employeeDataTable.Load(employeeService.getEmployeeDetailsDataReader(query));
            return employeeDataTable;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void searchFirstNamelabel_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.First_name = firstNameTextBox.Text;
            employee.Last_name = lastNameTextBox.Text;
            employee.Age = Int32.Parse(ageTextBox.Text);
            if (maleRadioButton.Checked)
                employee.Gender = "Male";
            else
                employee.Gender = "Female";
            employee.Mobile = mobileTextBox.Text;
            employee.Email = emailTextBox.Text;
            employee.Add1 = addressLine1.Text;
            employee.Add2 = addressLine2.Text;
            employee.Add3 = addressLine3.Text;
            employee.Department = departmntComboBox.Text;

            employeeService.insertEmployee(employee);
            searchResults.DataSource = getEmployeeList();
            clearForm();
        }

        private void clearForm() {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            ageTextBox.Text = "";
            maleRadioButton.Checked = true;
            FemaleRadioButton.Checked = false;
            mobileTextBox.Text = "";
            emailTextBox.Text = "";
            addressLine1.Text = "";
            addressLine2.Text = "";
            addressLine3.Text = "";
            departmntComboBox.Text = "";
        }

        private void updateFindButton_Click(object sender, EventArgs e)
        {
            updateDataGridView.DataSource = loadDataById(updateIdTextBox.Text);
        }

        private DataTable loadDataById(String id) {
            DataTable dataTable = new DataTable();
            String query;
            if (id.Length == 0)
                query = "SELECT id as 'ID', first_name as 'First Name', last_name as 'Last Name', age as 'Age', gender as 'Gender', mobile as 'Mobile', email as 'Email', address1 as 'Address1', address2 as 'Address2', address3 as 'Address3', department as 'Departmnt' FROM employees";
            else
                query = String.Format("SELECT id as 'ID', first_name as 'First Name', last_name as 'Last Name', age as 'Age', gender as 'Gender', mobile as 'Mobile', email as 'Email', address1 as 'Address1', address2 as 'Address2', address3 as 'Address3', department as 'Departmnt' FROM employees WHERE id = '{0}'", id);
            dataTable.Load(employeeService.getEmployeeDetailsDataReader(query));
            return dataTable;
        }

        private void updateDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            updateFirstNameTextBox.Text = updateDataGridView.CurrentRow.Cells[1].Value.ToString();
            updateLastNameTextBox.Text = updateDataGridView.CurrentRow.Cells[2].Value.ToString();
            updateAgeTextBox.Text = updateDataGridView.CurrentRow.Cells[3].Value.ToString();
            if (updateDataGridView.CurrentRow.Cells[4].Value.ToString().Equals("Male"))
            {
                updateMaleRadioButton.Checked = true;
                updateFemaleRadioButton.Checked = false;
            }
            else {
                updateMaleRadioButton.Checked = false;
                updateFemaleRadioButton.Checked = true;
            }
            updateMobileTextBox.Text = updateDataGridView.CurrentRow.Cells[5].Value.ToString();
            updateEmailTextBox.Text = updateDataGridView.CurrentRow.Cells[6].Value.ToString();
            updateAdd1TextBox.Text = updateDataGridView.CurrentRow.Cells[7].Value.ToString();
            updateAdd2TextBox.Text = updateDataGridView.CurrentRow.Cells[8].Value.ToString();
            updateAdd3TextBox.Text = updateDataGridView.CurrentRow.Cells[9].Value.ToString();
            updateDeptComboBox.Text = updateDataGridView.CurrentRow.Cells[10].Value.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Id = Int32.Parse(updateDataGridView.CurrentRow.Cells[0].Value.ToString());
            employee.First_name = updateFirstNameTextBox.Text;
            employee.Last_name = updateLastNameTextBox.Text;
            if (updateAgeTextBox.Text.Length > 0)
                employee.Age = Int32.Parse(updateAgeTextBox.Text);
            else
                employee.Age = null;
            if (updateMaleRadioButton.Checked)
                employee.Gender = "Male";
            else
                employee.Gender = "Female";
            employee.Mobile = updateMobileTextBox.Text;
            employee.Email = updateEmailTextBox.Text;
            employee.Add1 = updateAdd1TextBox.Text;
            employee.Add2 = updateAdd2TextBox.Text;
            employee.Add3 = updateAdd3TextBox.Text;
            employee.Department = updateDeptComboBox.Text;

            employeeService.updateEmployee(employee);
            searchResults.DataSource = getEmployeeList();
            updateDataGridView.DataSource = loadDataById(updateIdTextBox.Text);
            deleteDataGridView.DataSource = loadDataById(deleteIdtextBox.Text);

        }

        private void deleteFindButton_Click(object sender, EventArgs e)
        {
            deleteDataGridView.DataSource = loadDataById(deleteIdtextBox.Text);
        }

        private void deleteDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
              
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            employeeService.deleteEmployee(Int32.Parse(deleteDataGridView.CurrentRow.Cells[0].Value.ToString()));
            deleteDataGridView.DataSource = loadDataById(deleteIdtextBox.Text);
            searchResults.DataSource = getEmployeeList();
            updateDataGridView.DataSource = loadDataById(updateIdTextBox.Text);
        }
    }   
}
