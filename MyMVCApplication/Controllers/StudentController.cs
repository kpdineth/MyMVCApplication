using MyMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class StudentController : Controller
    {
        static IList<Student> studentList = new List<Student>{
                new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                new Student() { StudentId = 4, StudentName = "Chris" , Age = 17 } ,
                new Student() { StudentId = 4, StudentName = "Rob" , Age = 19 }
            };
        //GET: Student
        public ActionResult Index()
        {
            //var x = "This is Index action method of StudentController";
            return View(studentList);
            return View(studentList.OrderBy(s => s.StudentId).ToList());
            //return ViewPage("This is Index action method of StudentController");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            // delete student from the database whose id matches with specified id

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Student std) // creating std object from student class it has all the properies in student 
        //public ActionResult Edit([Bind(Include = "StudentId, StudentName")] Student std) // need to check with chamilar 
        {
            // update student to the database

            var id = std.StudentId;
            var name = std.StudentName;
            var age = std.Age;
            var standardName = std.StudentName; // this one need to check with chamiallar 

            //return RedirectToAction("Index","Home");
            return View("Index");
        }
        public ActionResult Edit(int? id) // creating std object from student class it has all the properies in student 
        //public ActionResult Edit([Bind(Include = "StudentId, StudentName")] Student std) // need to check with chamilar 
        {
            // update student to the database

            //Student stdt = new Student();
            //Standard st12 = new Standard();

            return View("Edit");
            //return RedirectToAction("Index", "Home");
            //return RedirectToAction("Edit");

        }

        [ActionName("Find")]
        public ActionResult GetById(int id)
        {
            // get student from the database 
            return View();
        }

        public StudentController()
        {
        }


        [NonAction]
        public Student GetStudent(int id)
        {
            return studentList.Where(s => s.StudentId == id).FirstOrDefault();
        }

        [HttpPost]
        public ActionResult PostAction() // handles POST requests by default
        {
            return View("Index");
        }


        [HttpPut]
        public ActionResult PutAction() // handles PUT requests by default
        {
            return View("Index");
        }

        [HttpDelete]
        public ActionResult DeleteAction() // handles DELETE requests by default
        {
            return View("Index");
        }

        [HttpHead]
        public ActionResult HeadAction() // handles HEAD requests by default
        {
            return View("Index");
        }

        [HttpOptions]
        public ActionResult OptionsAction() // handles OPTION requests by default
        {
            return View("Index");
        }

        [HttpPatch]
        public ActionResult PatchAction() // handles PATCH requests by default
        {
            return View("Index");
        }

        [AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get)]
        public ActionResult GetAndPostAction()
        {
            return RedirectToAction("Index");
        }

    }
}