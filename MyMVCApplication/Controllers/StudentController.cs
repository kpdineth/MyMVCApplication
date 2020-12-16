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
        //HTTPGET: Student,The HTTP GET request embeds data into a query string
        public ActionResult Index()
        {
            //var x = "This is Index action method of StudentController";
            return View(studentList);
            //return View(studentList.OrderBy(s => s.StudentId).ToList());
            //return ViewPage("This is Index action method of StudentController");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            // delete student from the database whose id matches with specified id

            return RedirectToAction("Index");
        }

        [HttpPost]//THis is the post when Save is clicked. It posts all updated model data back
        public ActionResult Edit(Student std) // creating std object from student class it has all the properies in student 
        //public ActionResult Edit([Bind(Include = "StudentId, StudentName")] Student std) // need to check with chamilar ( This is one way of doing it. Your avove line is also correct ) 
        {
            //anything else?
            // i need to go throu if i have any thing i ask tommorow 
            //Is this confusing? get ididnt undersd which part?
            //var id = std.StudentId;
            //var name = std.StudentName;
            //var age = std.Age;
            //var standardName = std.standard.StandardName;
            // update student to the database

            //var id = std.StudentId;
            //var name = std.StudentName;
            //var age = std.Age;
            //var standardName = std.StudentName; // this one need to check with chamiallar 
            //If you have database, this should have updated to database.
            //do you understand now?
            //Here you shoud udpate
            //return RedirectToAction("Index","Home");

            var student = studentList.Where(s => s.StudentId == std.StudentId).FirstOrDefault();
            studentList.Remove(student);
            studentList.Add(std);

            //return View("Edit");

            return View("Index");
        }

        [HttpGet]//This is a get. It get the details of one student
        public ActionResult Edit(int? id) // creating std object from student class it has all the properies in student 
        //public ActionResult Edit([Bind(Include = "StudentId, StudentName")] Student std) // need to check with chamilar 
        {
            // update student to the database - This is wrong, You cant update here. Its jsut a get/select from the list or db

            //Student stdt = new Student();
            //Standard st12 = new Standard();

            //Ok when the edit button is clicked in the grid it is sending a get request to this action method 

            //First you have to get the student from the student list. In this case from the top list
            Student std = studentList.FirstOrDefault(s => s.StudentId == id);//Here it select the student object using the id from above list

            return View(std);   // in here is it returning the object to the from that you show me few seconds ago?
            // Its passing std object to the Edit view ( Edit.cshtml )
            //return RedirectToAction("Index", "Home");
            //return RedirectToAction("Edit");

        }


        public ActionResult Edit()
        {
            return RedirectToAction("Index");
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