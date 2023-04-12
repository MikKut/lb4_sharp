using Models.Domain;
using Models.Entities;
using Models.Domain;
using Models.Entities;

namespace Mappers;

public class EmployeeMapper
    : ICompanyMapper<EmployeeDomain, EmployeeEntity>
{
    public EmployeeDomain ToDomain(EmployeeEntity employee)
    {
        return new EmployeeDomain(employee.Id, employee.FirstName, employee.LastName, employee.Salary);
    }

    public EmployeeEntity ToEntity(EmployeeDomain employee)
    {
        return new EmployeeEntity()
        {
            Id = employee.Id,
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            Salary = employee.Salary
        };
    }
}
