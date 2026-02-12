using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RuslanaTitovaKt42_22_22.DataBase.Helpers;
using RuslanaTitovaKt42_22_22.Models;

namespace RuslanaTitovaKt42_22_22.DataBase.Configurations
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        private const string TableName = "cd_position";

        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ToTable(TableName);

            builder.HasKey(p => p.PositionId)
                   .HasName($"pk_{TableName}_position_id");

            builder.Property(p => p.PositionId)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("position_id")
                   .HasComment("Идентификатор должности");

            builder.Property(p => p.PositionName)
                   .IsRequired()
                   .HasColumnName("c_position_name")
                   .HasColumnType(ColumnType.String).HasMaxLength(50)
                   .HasComment("Название должности");
        }
    }
}
