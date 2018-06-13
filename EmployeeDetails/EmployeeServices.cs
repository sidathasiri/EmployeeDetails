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

        public void fetchEmployee(Employee employee) { 
            //fetch emp
        }

        public void deleteEmployee(Employee employee) { 
            //delete emp
        }
    }
}
