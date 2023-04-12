using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{

    [Table("Employee")]
    public class EmployeeEntity
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        [ForeignKey(nameof(DepartmentEntity))]
        public string DepartmentId { get; set; }
        public DepartmentEntity? Department { get; set; }
    }
}