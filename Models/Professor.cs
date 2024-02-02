using System;
using System.Collections.Generic;

namespace EducationPortal.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Course> CoursesTaught { get; set; }


        public Professor()
        {
            CoursesTaught = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            if (course != null && !CoursesTaught.Contains(course))
            {
                CoursesTaught.Add(course);
            }
        }

        public void RemoveCourse(Course course)
        {
            if (course != null && CoursesTaught.Contains(course))
            {
                CoursesTaught.Remove(course);
            }
        }


        public List<Course> GetCoursesTaught()
        {
            return CoursesTaught;
        }

    }
}
