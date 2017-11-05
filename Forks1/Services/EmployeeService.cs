using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Forks1.Models;

namespace Forks1.Services
{
    public class EmployeeService : IEmployeeService
    {
        private Forks1DB db = new Forks1DB();

        public List<EmployeeViewModel> GetAll()
        {
            var employeeList = db.Employees.ToList();
            return employeeList.Select(emp => EmpDto(emp)).ToList();
        }

        private static EmployeeViewModel EmpDto(Employee emp)
        {
            return new EmployeeViewModel
            {
                EmployeeId  = emp.EmployeeId,
                FirstName   = emp.FirstName,
                LastName    = emp.LastName,
                Phone       = emp.Phone,
                Email       = emp.Email
            };
        }

        public EmployeeViewModel FindById(int id)
        {
            var employee = db.Employees.Find(id);
            return employee != null ? EmpDto(employee) : null;
        }

        public EmployeeViewModel Create(EmployeeViewModel employee)
        {
            var emp = fromEmp(employee);
            db.Employees.Add(emp);
            db.SaveChanges();

            employee.EmployeeId = emp.EmployeeId;
            return EmpDto(emp);
        }

        private static Employee fromEmp(EmployeeViewModel employee)
        {
            var emp = new Employee
            {
                EmployeeId = employee.EmployeeId,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Phone = employee.Phone,
                Email = employee.Email
            };
            return emp;
        }

        public EmployeeViewModel Save(EmployeeViewModel employee)
        {
            var emp = fromEmp(employee);
            db.Entry(emp).State = EntityState.Modified;
            db.SaveChanges();
            return EmpDto(emp);
        }

        public void Delete(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}