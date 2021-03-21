using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Day_4.Models;

namespace MVC_Day_4.Models
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentList()
        {
            return View(StudentMoc.GetStudents());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student, HttpPostedFileBase img)
        {
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    string filename = student.Name + DateTime.Now.Millisecond + "." + img.FileName.Split('.')[1];
                    img.SaveAs(Server.MapPath("~/Imgs/") + filename);
                    student.Img = filename;
                }
                else
                {
                    student.Img = "/noone.png";
                }

                StudentMoc.addNewStudent(student);
                return RedirectToAction("StudentList");
            }
            else
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            StudentMoc.deleteStudent(id);
            return RedirectToAction("StudentList");
        }

        public ActionResult Studnet(int id)
        {
            return View(StudentMoc.getStudnetByID(id));
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            return View(StudentMoc.getStudnetByID(id));
        }

        [HttpPost]
        public ActionResult Update(Student student, HttpPostedFileBase img)
        {
            if (ModelState.IsValid)
            {
                if (img != null)
                {
                    string filename = student.Name + DateTime.Now.Millisecond + "." + img.FileName.Split('.')[1];
                    img.SaveAs(Server.MapPath("~/Imgs/") + filename);
                    student.Img = filename;
                }
                else
                {
                    student.Img = "/noone.png";
                }
                StudentMoc.updateStudent(student);
                return RedirectToAction("StudentList");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Files()
        {
            int[] arr = { 1, 2, 3 };
            return View(arr);
        }

        public ActionResult Download(int id)
        {
            return File(Server.MapPath("~/Files/") + id.ToString() + ".pdf", "text/plain", "Std" + id.ToString() + ".pdf");
        }

        public ActionResult inPageAjaxDetailes(int id)
        {

            return PartialView(StudentMoc.getStudnetByID(id));
        }

        public ActionResult modelAjaxDetailes(int id)
        {

            return PartialView(StudentMoc.getStudnetByID(id));
        }
        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                HttpCookie cookie = new HttpCookie("ch");
                cookie.Values["Email"] = model.Email;
                cookie.Values["Password"] = model.Password;
                Response.Cookies.Add(cookie);
                return RedirectToAction("StudentList");
            }
            else
            {
                return View();
            }
        }

        public ActionResult showCookies()
        {
            try
            {
                HttpCookie c = Request.Cookies.Get("ch");
                ViewBag.email = c.Values["Email"];
                ViewBag.password = c.Values["Password"];
            }
            catch (Exception)
            {

                ViewBag.email = "Not Founded";
                ViewBag.password = "Not Founded";
            }
           
            return PartialView();
        }

    }
}