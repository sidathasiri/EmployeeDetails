using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace EmployeeDetails
{
    class EmployeeDao {
        DBConnect dbConnector;
   
        public EmployeeDao() {
            dbConnector = new DBConnect();
        }

        public void insertEmployee(Employee employee)
        {
            Console.WriteLine("ïnserting " + employee.First_name + " in dao");
            string query = string.Format("INSERT INTO employees (first_name, last_name, age, gender, mobile, email, address1, address2, address3, department) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", employee.First_name, employee.Last_name, employee.Age, employee.Gender, employee.Mobile, employee.Email, employee.Add1, employee.Add2, employee.Add3, employee.Department);
            dbConnector.execute(query);
        }

        public void updateEmployee(Employee employee)
        {
            // update emp
        }

        public List<Employee> fetchAllEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            string query = "SELECT * FROM employees";
            MySqlConnection conn = dbConnector.getConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read()) {
                Employee emp = new Employee();
                emp.First_name = (string)dataReader["first_name"];
                emp.Last_name = (string)dataReader["last_name"];
                emp.Age = (int)dataReader["age"];
                emp.Gender = (string)dataReader["gender"];
                emp.Mobile = (string)dataReader["mobile"];
                emp.Email = (string)dataReader["email"];
                emp.Add1 = (string)dataReader["address1"];
                emp.Add2 = (string)dataReader["address2"];
                emp.Add3 = (string)dataReader["address3"];
                emp.Department = (string)dataReader["department"];
                employeeList.Add(emp);
            }
            conn.Close();

            return employeeList;

        }

        public MySqlDataReader getEmployeeDetailsDataReader() {
            string query = "SELECT * FROM employees";
            MySqlConnection conn = dbConnector.getConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            return cmd.ExecuteReader();
        }

        public void deleteEmployee(Employee employee)
        {
            //delete emp
        }
    }
}
