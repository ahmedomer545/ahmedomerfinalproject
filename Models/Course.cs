using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ahmedomerfinalproject.Models
{
    public class Course
    {
        public int CourseID {get; set;} 
        [Required]
        public string Description {get; set;}
        public List<StudentCourse> StudentCourses {get; set;}  
    }

    public class StudentCourse
    {
        public int CourseID {get; set;}     
        public int StudentID {get; set;}    
        public Student Student {get; set;}  
        public Course Course {get; set;}   
    }
}