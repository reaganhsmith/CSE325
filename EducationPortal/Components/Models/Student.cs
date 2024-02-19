namespace educationPortal.Models;

public class Student
{
    public int StudentId { get; set; }
    public required string Name { get; set; } 
    public required string Email { get; set; }
    public required string Phone { get; set; }
    public required string Major { get; set; }
}




// public class Student
// {
//     public int StudentId { get; set; }
//     public string? Name { get; set; } 
//     public string? Email { get; set; }
//     public string? Phone { get; set; }
//     public string? Major { get; set; }
// }
