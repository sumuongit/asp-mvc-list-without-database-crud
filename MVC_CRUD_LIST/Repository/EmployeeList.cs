using MVC_CRUD_LIST.Models;
using System.Collections.Generic;

namespace MVC_CRUD_LIST.Repository
{
    public static class EmployeeList
    {
        static List<Employee> empList = null;
        static EmployeeList()
        {
            empList = new List<Employee>(){            
            new Employee()
            {
                EmployeeID = 1,
                Name = "Salahuddin Ahmed",
                Age = 38,
                State = "Dhaka",
                Country = "Bangladesh"
            }
            };
        }

        public static List<Employee> SelectEmployeeList()
        {       
            return empList;
        }

        public static void InsertEmployeeList(Employee emp)
        {
            empList.Add(emp);
        }

        public static void UpdateEmployeeList(Employee emp)
        {
            Employee empUpdate = empList.Find(x => x.EmployeeID == emp.EmployeeID);
            empUpdate.Name = emp.Name;
            empUpdate.Age = emp.Age;
            empUpdate.State = emp.State;
            empUpdate.Country = emp.Country;
        }
        public static void DeleteEmployeeList(int id)
        {
            Employee empDelete = empList.Find(x => x.EmployeeID == id);
            empList.Remove(empDelete);
        }
    }
}