using SchoolManagementSystem.AllMethods;
using SchoolManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            List<AddTeacher> teach=Teacher.GetAllTeacher();
            return View(teach);
        }

        // GET: Teacher/Details/5
        public ActionResult Details(int id)
        {
            AddTeacher teach = Teacher.GetSingleTeacher(id);
            return View(teach);
        }

        // GET: Teacher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teacher/Create
        [HttpPost]
        public ActionResult Create(AddTeacher teach)
        {
            try
            {
                // TODO: Add insert logic here
                Teacher.Insert(teach);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Teacher/Edit/5
        public ActionResult Edit(int id)
        {
            AddTeacher teach = Teacher.GetSingleTeacher(id);
            return View(teach);
           
        }

        // POST: Teacher/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AddTeacher teach)
        {
            try
            {
                // TODO: Add update logic here
                Teacher.Edit(id,teach);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Teacher/Delete/5
        public ActionResult Delete(int id)
        {
            AddTeacher teach = Teacher.GetSingleTeacher(id);
            return View(teach);
        }

        // POST: Teacher/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Teacher.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
