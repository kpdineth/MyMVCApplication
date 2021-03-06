﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // when i add
using System.Linq;
using System.Web;

namespace MyMVCApplication.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Display(Name = "Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }
        
    }

    public class Standard
    {
        //public object Standard { get; internal set; }
        public int StandardId { get; set; }
        public string StandardName { get; set; }
    }
}