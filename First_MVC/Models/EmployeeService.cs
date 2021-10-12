using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_MVC.Models
{
    public class EmployeeService : IEmployee
    {
        private List<Employee> Employees;
        public EmployeeService()
        {
            this.Employees = new List<Employee>()
            {
    new Employee(){Id=1,Name="ajay",Salary=12000,Dept="IT"},
    new Employee(){Id=2,Name="Rohit",Salary=17000,Dept="IT"},
    new Employee(){Id=3,Name="ajay",Salary=19000,Dept="HR"},

            };
        }
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = Employees.Count + 1;
            Employees.Add(employee);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return Employees.ToList();
        }
    }
}
