using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ahmedomerfinalproject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CourseContext(serviceProvider.GetRequiredService<DbContextOptions<CourseContext>>()))
            {
                if (context.Student.Any())
                {
                    return;
                }

                List<Student> students = new List<Student> {
                    new Student {FirstName="Ahmed", LastName="Omer"},
                    new Student {FirstName="James", LastName="Jones"},
                    new Student {FirstName="Mickey", LastName="Mouse"},
                    new Student {FirstName="Michael", LastName="Jordan"},
                    new Student {FirstName="Norris", LastName="Cole"},
                    new Student {FirstName="Harley", LastName="Davidson"},
                    new Student {FirstName="Jeff", LastName="Teague"},
                    new Student {FirstName="Kyle", LastName="owry"},
                    new Student {FirstName="James", LastName="Worthy"},
                    new Student {FirstName="Fatima", LastName="Samater"},
                    new Student {FirstName="Mahad", LastName="Omer"},
                    new Student {FirstName="Awet", LastName="Yohannes"},
                    new Student {FirstName="Mo", LastName="Farah"},
                    new Student {FirstName="Quinton", LastName="Livelong"},
                    new Student {FirstName="Perky", LastName="Longjohn"},
                    new Student {FirstName="Raplh", LastName="Lauren"},
                    new Student {FirstName="Harry", LastName="Potter"},
                    new Student {FirstName="Larry", LastName="Bird"},
                    new Student {FirstName="Awal", LastName="Jabeer"},
                    new Student {FirstName="Steve", LastName="Scott"},
                    new Student {FirstName="Ezekiel", LastName="Too"},
                    new Student {FirstName="Boni", LastName="Mone"},
                    new Student {FirstName="Al", LastName="Capone"},
                    new Student {FirstName="Grevious", LastName="Lockhard"},
                    new Student {FirstName="Lily", LastName="Mae"},
                    new Student {FirstName="Tyler", LastName="Hike"},
                    new Student {FirstName="Omer", LastName="Omer"},
                    new Student {FirstName="Maryam", LastName="Abdi"},
                    new Student {FirstName="Amina", LastName="Tyson"},
                    new Student {FirstName="Ayman", LastName="Larry"},
                };
                context.AddRange(students);

                List<Course> courses = new List<Course> {
                    new Course {Description = "Hist 2315"},
                    new Course {Description = "CIDM 3312"},
                    new Course {Description = "POLS 2305"},
                    new Course {Description = "ENGL 2300"},
                    new Course {Description = "ENGL 1000"},
                    new Course {Description = "MATH 1860"},
                    new Course {Description = "MATH 5460"},
                };
                context.AddRange(courses);

                List<StudentCourse> enrollment = new List<StudentCourse> {
                    new StudentCourse {CourseID = 1, StudentID = 12},
                    new StudentCourse {CourseID = 1, StudentID = 15},
                    new StudentCourse {CourseID = 1, StudentID = 19},
                    new StudentCourse {CourseID = 1, StudentID = 3},
                    new StudentCourse {CourseID = 1, StudentID = 9},
                    new StudentCourse {CourseID = 1, StudentID = 2},
                    new StudentCourse {CourseID = 1, StudentID = 5},
                    new StudentCourse {CourseID = 1, StudentID = 16},
                    new StudentCourse {CourseID = 1, StudentID = 17},

                    new StudentCourse {CourseID = 2, StudentID = 1},
                    new StudentCourse {CourseID = 2, StudentID = 6},
                    new StudentCourse {CourseID = 2, StudentID = 9},
                    new StudentCourse {CourseID = 2, StudentID = 4},
                    new StudentCourse {CourseID = 2, StudentID = 16},
                    new StudentCourse {CourseID = 2, StudentID = 11},
                    new StudentCourse {CourseID = 2, StudentID = 24},
                    new StudentCourse {CourseID = 2, StudentID = 10},
                    new StudentCourse {CourseID = 2, StudentID = 23},
                };
                context.AddRange(enrollment);

                context.SaveChanges();
            }
        }
    }
}