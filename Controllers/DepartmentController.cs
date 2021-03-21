using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Day_4.Models;

namespace MVC_Day_4.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult DeptList()
        {
            ViewBag.Depts = DepartmentMoc.GetDepartments();
            return View();
        }

        public ActionResult Delete(int id)
        {
            DepartmentMoc.deleteDept(id);
            ViewBag.Depts = DepartmentMoc.GetDepartments();
            return PartialView("PartialDepartment");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            DepartmentMoc.addNewDept(department);
            return RedirectToAction("DeptList");
        }

        public ActionResult Dept(int id)
        {
            return View(DepartmentMoc.getDeptByID(id));
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            return View(DepartmentMoc.getDeptByID(id));
        }

        [HttpPost]
        public ActionResult Update(Department department)
        {
            DepartmentMoc.updateDept(department);
            return RedirectToAction("DeptList");
        }

        public ActionResult Add(Department department)
        {
            DepartmentMoc.addNewDept(department);
            ViewBag.Depts = DepartmentMoc.GetDepartments();
            return PartialView("PartialDepartment");
        }
    }
}