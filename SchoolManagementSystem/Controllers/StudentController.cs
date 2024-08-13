using SchoolManagementSystem.AllMethods;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<StudentAdmission> sd = Student.GetAllStudent();
            return View(sd);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            StudentAdmission single = Student.GetSingleStudent(id);
            return View(single);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(StudentAdmission std)
        {
            try
            {
                Student.Insert(std);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            StudentAdmission single = Student.GetSingleStudent(id);
            return View(single);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, StudentAdmission std)
        {
            try
            {
                Student.Edit(id,std);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            StudentAdmission single = Student.GetSingleStudent(id);
            return View(single);
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, StudentAdmission std)
        {
            try
            {
                // TODO: Add delete logic here
                Student.DeleteStudent(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
