﻿using MySql.Data.MySqlClient;
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
            // update emp
        }

        public List<Employee> fetchAllEmployees()
        {
            return employeeDao.fetchAllEmployees();
        }

        public void deleteEmployee(Employee employee) { 
            //delete emp
        }

        public MySqlDataReader getEmployeeDetailsDataReader() {
            return employeeDao.getEmployeeDetailsDataReader();
        } 
    }
}
