using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVCApplication.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public Standard standard { get; set; }

    }

    //Model binding also works on complex types.
    //It will automatically convert the input fields data on the view to the properties of a complex type parameter of an action method in HttpPost request if the properties' names match with the fields on the view.
    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
    }
}