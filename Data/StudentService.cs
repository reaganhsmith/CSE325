using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServerBlazorEF.Models;

namespace ServerBlazorEF.Data
{
    public class StudentService
    {
        private readonly SchoolDbContext _context;

        public StudentService(SchoolDbContext context)
        {
            _context = context;
        }

        // CRUD operations for students

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student?> GetStudentByIdAsync(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task<Student> InsertStudentAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<Student> UpdateStudentAsync(int id, Student student)
        {
            var existingStudent = await _context.Students.FindAsync(id);

            if (existingStudent == null)
            {
                throw new InvalidOperationException("Student not found");
            }

            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.School = student.School;

            await _context.SaveChangesAsync();

            return existingStudent;
        }

        public async Task<Student> DeleteStudentAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }

            return student!;
        }

        // Authentication methods

        public async Task<Student> AuthenticateAsync(string email, string password)
        {
            var student = await _context.Students.FirstOrDefaultAsync(s => s.Email == email && s.Password == password);
            return student!;
        }

        // Additional method to get a student by email
        public async Task<Student?> GetStudentByEmailAsync(string email)
        {
            return await _context.Students.FirstOrDefaultAsync(s => s.Email == email);
        }
    }
}
