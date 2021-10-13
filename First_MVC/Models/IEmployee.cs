using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_MVC.Models
{
   public interface IEmployee
    {
        Employee AddEmployee(Employee employee);
        List<Employee> GetEmployees();
        bool DeleteEmployee(int id);
    }
}
