using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities
{

    [Table("Department")]
    public class DepartmentEntity
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public ICollection<EmployeeEntity> Employees { get; set; }
    }
}