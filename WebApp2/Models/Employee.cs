using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp2.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? Fullname { get; set; }
        public int? age { get; set; }
        public decimal? Salary { get; set; }
        public int? State { get; set; } = 1;

        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime? Modified { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department department { get; set; }
    }
}
