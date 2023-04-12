using Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyView
{
    public partial class AddEmployeeForm : Form
    {
        private DepartmentDomain _department;
        private EmployeeDomain _employeeToUpdate;
        public AddEmployeeForm(DepartmentDomain department)
        {
            _department = department;
            InitializeComponent();
        }
        public AddEmployeeForm(EmployeeDomain employee)
        {
            _employeeToUpdate = employee;
            InitializeComponent();

            SetEmployeeDataToInputFields(_employeeToUpdate);
        }

        private void addOrUpdateDepartmentButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            int salary = (int)salaryNumericUpDown.Value;

            if (_employeeToUpdate == null)
            {
                var employee = new EmployeeDomain(firstName, lastName, salary);
                _department.AddEmployee(employee);
            }
            else
            {
                _employeeToUpdate.FirstName = firstName;
                _employeeToUpdate.LastName = lastName;
                _employeeToUpdate.Salary = salary;
            }

            Close();
        }
        private void SetEmployeeDataToInputFields(EmployeeDomain employee)
        {
            FirstNameTextBox.Text = employee.FirstName;
            LastNameTextBox.Text = employee.LastName;
            salaryNumericUpDown.Value = employee.Salary;
        }

        private void FirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
