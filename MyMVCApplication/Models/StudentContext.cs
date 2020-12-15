using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyMVCApplication.Models
{
    public class StudentContext : DbContext   // DbContext is a class inside the frame entity frame work
    {
        public StudentContext() : base()
        {
        }
        public DbSet<Student> Students { get; set; }   //Dbset is a kind of a list
    }
}