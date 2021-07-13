using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;


        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id = 1,Name = "Eric", Department=Dept.Sociology, Email="eric123@gmail.com"},
                new Employee() { Id = 2, Name = "Stan", Department = Dept.Finance, Email = "stan123@gmail.com" },
                new Employee() { Id = 3, Name = "Kyle", Department = Dept.Law, Email = "kyle123@gmail.com" },

            };
            
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int Id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == Id);
            if(employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return this._employeeList.FirstOrDefault(x => x.Id == Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee =  _employeeList.FirstOrDefault(e => e.Id == employeeChanges.Id);

            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
