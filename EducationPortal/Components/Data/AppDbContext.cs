using Microsoft.EntityFrameworkCore;
using educationPortal.Models;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=educationportal.db");
    }
}
