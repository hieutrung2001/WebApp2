using System.ComponentModel.DataAnnotations;

namespace WebApp2.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? State { get; set; } = 1;

        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime? Modified { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
