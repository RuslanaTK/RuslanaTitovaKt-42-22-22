using Microsoft.EntityFrameworkCore;
using RuslanaTitovaKt42_22_22.DataBase.Configurations;
using RuslanaTitovaKt42_22_22.Models;

namespace RuslanaTitovaKt42_22_22.DataBase
{
    public class CathedralDbContext : DbContext
    {
        DbSet<Cathedral> Cathedrals { get; set; }
        DbSet<Teacher> Teachers { get; set; }
        DbSet<Discipline> Disciplines { get; set; }
        DbSet<Position> Positions { get; set; }
        DbSet<AcademicDegree> AcademicDegrees { get; set; }
        DbSet<Workload> Workloads { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CathedralConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new AcademicDegreeConfiguration());
            modelBuilder.ApplyConfiguration(new PositionConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new WorkloadConfiguration());
        }
        public CathedralDbContext(DbContextOptions<CathedralDbContext> options) : base(options)
        {


        }
    }
}
