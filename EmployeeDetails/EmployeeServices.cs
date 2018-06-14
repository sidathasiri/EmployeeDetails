using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    class EmployeeServices{

        EmployeeDao employeeDao = new EmployeeDao();

        public void insertEmployee(Employee employee) {
            employeeDao.insertEmployee(employee);
        }

        public void updateEmployee(Employee employee) {
            employeeDao.updateEmployee(employee);
        }

        public List<Employee> fetchAllEmployees()
        {
            return employeeDao.fetchAllEmployees();
        }

        public void deleteEmployee(int id) {
            employeeDao.deleteEmployee(id);
        }

        public MySqlDataReader getEmployeeDetailsDataReader(String query) {
            return employeeDao.getEmployeeDetailsDataReader(query);
        }
    }
}
