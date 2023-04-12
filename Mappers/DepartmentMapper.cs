using Models.Domain;
using Models.Entities;

namespace Mappers;

public class DepartmentMapper
    : ICompanyMapper<DepartmentDomain, DepartmentEntity>
{
    private static ICompanyMapper<EmployeeDomain, EmployeeEntity> _employeeMapper;
    private static DepartmentMapper _instance;
    private DepartmentMapper()
    { 
    
    }
    static DepartmentMapper()
    {
       _instance = new DepartmentMapper();
       _employeeMapper = new EmployeeMapper();
    }

    public static DepartmentMapper GetInstanse()
    {
        return _instance;
    }

    public DepartmentDomain ToDomain(DepartmentEntity department)
    {
        return new DepartmentDomain(department.Id, department.Title, department.Employees.Select(x => _employeeMapper.ToDomain(x)).ToList());
    }

    public DepartmentEntity ToEntity(DepartmentDomain department)
    {
        return new DepartmentEntity
        {
            Id = department.Id,
            Title = department.Title,
            Employees = department.GetEmployees().Select(x => _employeeMapper.ToEntity(x)).ToList()
        };
    }
}