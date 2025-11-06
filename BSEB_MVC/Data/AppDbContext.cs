using BSEB_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BSEB_MVC.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<FacultyMaster> Faculty_Mst { get; set; }
        public DbSet<StudentMaster> Student_Mst { get; set; }
        public DbSet<CollegeMaster> CollegeMaster { get; set; }
        public DbSet<Student_PayMst> Student_PayMst { get; set; }
        //public DbSet<CollegeMaster> CollegeMaster { get; set; }
        //public DbSet<Student_PayMst> Student_PayMst { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ✅ Mark StudentMaster as keyless for SP result mapping
            modelBuilder.Entity<FacultyMaster>().HasKey(f => f.Pk_FacultyId);
            modelBuilder.Entity<StudentMaster>().HasNoKey();
            modelBuilder.Entity<CollegeMaster>().HasNoKey();
            modelBuilder.Entity<Student_PayMst>().HasNoKey();
        }
    }
}
