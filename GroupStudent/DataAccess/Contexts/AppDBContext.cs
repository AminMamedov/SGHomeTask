using groupStudent.CORE.Entities;
using Microsoft.EntityFrameworkCore;

namespace groupStudent.DataAccess.Contexts;

public class GCcontext : DbContext
{
    //AppContext context = new AppContext();


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=LAPTOP-8VT5QBPD\\SQLEXPRESS;Database=GCTask;Trusted_Connection=true");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentGroup>()
            .HasKey(sg => new { sg.StudentID, sg.GroupId });

        modelBuilder.Entity<Student>()
            .HasMany(s => s.StudentGroups)
            .WithOne(sg => sg.Student)
            .HasForeignKey(sg => sg.StudentID);

        modelBuilder.Entity<Group>()
            .HasMany(g => g.StudentGroups)
            .WithOne(sg => sg.Group)
            .HasForeignKey(sg => sg.GroupId);

        modelBuilder.Entity<Group>()
            .HasIndex(g => g.Name)
            .IsUnique();



    }
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Group> Groups { get; set; } = null!;
    public DbSet<StudentGroup> StudentGroups { get; set; } = null!;

}
