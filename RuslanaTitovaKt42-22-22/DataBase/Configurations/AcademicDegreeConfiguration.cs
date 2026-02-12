using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RuslanaTitovaKt42_22_22.DataBase.Helpers;
using RuslanaTitovaKt42_22_22.Models;

namespace RuslanaTitovaKt42_22_22.DataBase.Configurations
{
    public class AcademicDegreeConfiguration : IEntityTypeConfiguration<AcademicDegree>
    {
        private const string TableName = "cd_academic_degree";

        public void Configure(EntityTypeBuilder<AcademicDegree> builder)
        {
            builder.ToTable(TableName);

            builder.HasKey(p => p.AcademicDegreeId)
                   .HasName($"pk_{TableName}_academic_degree_id");

            builder.Property(p => p.AcademicDegreeId)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("academic_degree_id")
                   .HasComment("Идентификатор ученой степени");

            builder.Property(p => p.DegreeName)
                   .IsRequired()
                   .HasColumnName("c_degree_name")
                   .HasColumnType(ColumnType.String).HasMaxLength(50)
                   .HasComment("Название степени");
        }
    }
}