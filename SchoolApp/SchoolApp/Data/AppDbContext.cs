using Microsoft.EntityFrameworkCore;
using SchoolApp.Features.Assignments.Models;

namespace SchoolApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) {}
    
    public DbSet<AssignmentModel> Assignments { get; set; }
}