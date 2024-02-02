using System;
using System.Collections.Generic;

namespace EducationPortal.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Course> Courses { get; set; }

        public Student()
        {
            Courses = new List<Course>();
        }

        public void EnrollInCourse(Course course)
        {
            if (course != null && !Courses.Contains(course))
            {
                Courses.Add(course);
            }
        }

        public List<Course> GetEnrolledCourses()
        {
            return Courses;
        }

    }
}
