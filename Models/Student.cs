using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ahmedomerfinalproject.Models
{
    public class Student
    {



        public int StudentID {get; set;}
        [Display(Name = "First Name")]
        

        [Required]
        public string FirstName {get; set;}
        [Display(Name = "Last Name")]

        [Required]
        public string LastName {get; set;}


        public List<StudentCourse> StudentCourses {get; set;} 

    }
}