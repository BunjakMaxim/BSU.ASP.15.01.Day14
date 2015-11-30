using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BSU.ASP._15._01.Day14.Bunjak.Models;

namespace BSU.ASP._15._01.Day14.Bunjak.Controllers
{
    public class HomeController : Controller
    {
        TrainingContext db = new TrainingContext();

        public ActionResult Index()
        {
            IEnumerable<Training> trainings = db.Tranings;
            ViewBag.Tranings = trainings;
            return View();
        }

        [HttpGet]
        public ActionResult Registration(int id)
        {
            TempData["Id"] = id;
            ViewBag.Id = id;
            return View();
        }
        [HttpPost]
        public ActionResult Registration([Bind(Include = "Id,Name,Surname,Email,University,Course")]RegistrationStudent student)
        {
            student.TrainingId = (int)TempData["Id"];

            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                TempData["Massage"] = "Регистрация прошла успешно.";
                return RedirectToAction("ShowMassage");
            }
            TempData["Id"] = student.Id;
            return View(student);
        }

        public ActionResult ShowList(int id)
        {
            IEnumerable<RegistrationStudent> students = db.Students.Where(m => m.TrainingId == id);
            if(students.Count() != 0)
                return View(students);
            TempData["Massage"] = "На данный курс пока никто не зарегистрировался.";
            return RedirectToAction("ShowMassage");
        }

        public ActionResult ShowMassage()
        {
            ViewBag.Massage = TempData["Massage"];
            return View();
        }
    }
}