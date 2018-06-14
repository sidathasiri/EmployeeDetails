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
            employeeDataTable.Load(employeeService.getEmployeeDetailsDataReader());
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
            employeeService.fetchAllEmployees();
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
        }
    }
}
