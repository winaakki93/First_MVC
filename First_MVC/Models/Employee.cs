using System.ComponentModel.DataAnnotations;

namespace First_MVC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Dept { get; set; }
    }
}
