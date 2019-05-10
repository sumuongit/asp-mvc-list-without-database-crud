using MVC_CRUD_LIST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MVC_CRUD_LIST.Repository
{
    public interface IEmployeeRepository
    {
        List<Employee> SelectAllEmployees();
        Employee SelectEmployeeById(int id);
        void InsertEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void DeleteEmployee(int id);
    }
}