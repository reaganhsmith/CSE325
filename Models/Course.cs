using System;
using System.Collections.Generic;

namespace EducationPortal.Models
{
    public class Course
    {
   
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Professor CourseInstructor { get; set; }
        public List<Student> EnrolledStudents { get; set; } 

        public Course()
        {
            EnrolledStudents = new List<Student>();
            Assignments = new List<Assignment>();
        }



        public void EnrollStudent(Student student)
        {
            if (student != null && !EnrolledStudents.Contains(student))
            {
                EnrolledStudents.Add(student);
            }
        }

        public void UnenrollStudent(Student student)
        {
            if (student != null && EnrolledStudents.Contains(student))
            {
                EnrolledStudents.Remove(student);
            }
        }

        public void AddAssignment(Assignment assignment)
        {
            if (assignment != null && !Assignments.Contains(assignment))
            {
                Assignments.Add(assignment);
            }
        }
    }
}
