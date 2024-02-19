using educationPortal.Models;
namespace educationPortal;


public static class CourseClient
{
    private static readonly List<Course> courses = new()
    {
        new Course(){
            Code = "CSE234",
            Title = "Web Design 1",
            Time = "10am",
            Location = "Room 101",
            Instructor = "Brother Smith"
        },
        new Course(){
            Code = "CSE222",
            Title = "Software Engeneering",
            Time = "11am",
            Location = "Room 102",
            Instructor = "Brother Thomson"
        }
    };

    public static Course[] GetCourses()
    {
        return courses.ToArray();
    }
}