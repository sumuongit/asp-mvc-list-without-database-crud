using MVC_CRUD_LIST.Models;
using MVC_CRUD_LIST.Repository;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC_CRUD_LIST.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository rep = new EmployeeRepository();
        //
        // GET: /Employee/
        public ActionResult Index()
        {            
            IEnumerable<Employee> obj = rep.SelectAllEmployees();
            return View(obj);
        }

        //
        // GET: /Employee/Details/5
        public ActionResult Details(int id)
        {            
            Employee obj = rep.SelectEmployeeById(id);
            return View(obj);
        }

        //
        // GET: /Employee/Create
        public ActionResult Create()
        {            
            return View();
        }

        //
        // POST: /Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                rep.InsertEmployee(emp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employee/Edit/5
        public ActionResult Edit(int id)
        {
            Employee obj = rep.SelectEmployeeById(id);
            return View(obj);
        }

        //
        // POST: /Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                rep.UpdateEmployee(emp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employee/Delete/5
        public ActionResult Delete(int id)
        {
            Employee obj = rep.SelectEmployeeById(id);
            return View(obj);
        }

        //
        // POST: /Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                rep.DeleteEmployee(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
