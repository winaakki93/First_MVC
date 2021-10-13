using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_MVC.Models
{
    public class EmployeeService : IEmployee
    {
        private ApplicationContext Context { get; }

        public EmployeeService(ApplicationContext context)
        {
            Context = context;
        }

       

        public Employee AddEmployee(Employee employee)
        {
           
            Context.Employees.Add(employee);
            Context.SaveChanges();
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return Context.Employees.ToList();
        }
        public bool DeleteEmployee(int id)
        {
            if (Context.Employees.Any(e => e.Id == id))
            {
                var emp = Context.Employees.SingleOrDefault(e => e.Id == id);
                Context.Employees.Remove(emp);
                Context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
