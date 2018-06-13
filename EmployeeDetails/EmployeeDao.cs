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

        public void fetchEmployee(Employee employee)
        {
            //fetch emp
        }

        public void deleteEmployee(Employee employee)
        {
            //delete emp
        }
    }
}
