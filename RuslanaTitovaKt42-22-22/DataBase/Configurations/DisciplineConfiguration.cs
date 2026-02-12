using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RuslanaTitovaKt42_22_22.DataBase.Helpers;
using RuslanaTitovaKt42_22_22.Models;

namespace RuslanaTitovaKt42_22_22.DataBase.Configurations
{
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        private const string TableName = "cd_discipline";

        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.ToTable(TableName);

            builder.HasKey(p => p.DisciplineId)
                   .HasName($"pk_{TableName}_discipline_id");

            builder.Property(p => p.DisciplineId)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("discipline_id")
                   .HasComment("Идентификатор дисциплины");

            builder.Property(p => p.DisciplineName)
                   .IsRequired()
                   .HasColumnName("c_discipline_name")
                   .HasColumnType(ColumnType.String).HasMaxLength(100)
                   .HasComment("Название дисциплины");
        }
    }
}
