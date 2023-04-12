using Models.Domain;
using LanguageExt.Common;
using Mappers;
using Repositories;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;

namespace Controllers;

public class DepartmentController
{
    private List<DepartmentDomain> _departments;
    private IDepartmentRepository _departmentRepository;
    private static ICompanyMapper<DepartmentDomain, DepartmentEntity> _companyMapper;
    public DepartmentController()
    {
        _companyMapper = DepartmentMapper.GetInstanse();
        _departments = new List<DepartmentDomain>();
        _departmentRepository = new DepartmentJsonRepository();
    }

    public IEnumerable<DepartmentDomain> GetDepartments()
    {
        foreach (var item in _departments)
        {
            yield return item;
        }
    }
    public Result<bool> AddDepartment(DepartmentDomain department)
    {
        if (_departments.Any(x => x.Id == department.Id))
        {
            return new Result<bool>(new ArgumentException($"There is already a department with the same Id: {department.Id}"));
        }

        _departments.Add(department);
        return new Result<bool>(true);
    }
    public Result<bool> RemoveDepartment(string id)
    {
        var departmentToRemove = _departments.FirstOrDefault(x => x.Id == id);

        if (departmentToRemove == null)
        {
            return new Result<bool>(new ArgumentException($"There is no department with Id: {id}"));
        }

        _departments.Remove(departmentToRemove);
        return new Result<bool>(true);
    }
    public Result<bool> RemoveEmployeeFromDepartment(string departmentId, EmployeeDomain employee)
    {
        var department = _departments.FirstOrDefault(x => x.Id == departmentId);
        if (department == null)
        {
            return new Result<bool>(new ArgumentException($"There is no department with Id: {departmentId}"));
        }

        var result = department.RemoveEmployee(employee);
        if (result == false)
        {
            return new Result<bool>(new ArgumentException($"There is no any employee with Id: {employee.Id}"));
        }

        return new Result<bool>(true);
    }
    public Result<IEnumerable<EmployeeDomain>> GetEmployeeByDepartment(string departmentId)
    {
        var department = _departments.FirstOrDefault(x => x.Id == departmentId);
        if (department == null)
        {
            return new Result<IEnumerable<EmployeeDomain>>(new ArgumentException($"The collection does not have element with Id: {departmentId}"));
        }

        return new Result<IEnumerable<EmployeeDomain>>(department.GetEmployees());
    }

    public int LoadData()
    {
        _departments = _departmentRepository.GetAll().Select(x => _companyMapper.ToDomain(x)).ToList();
        return _departments.Count;
    }
    public void SaveData()
    {
        _departmentRepository.SaveAll(_departments.Select(x => _companyMapper.ToEntity(x)).ToList());
    }
}
