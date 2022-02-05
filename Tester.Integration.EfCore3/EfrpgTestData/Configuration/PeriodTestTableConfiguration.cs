// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
{
    // PeriodTestTable
    public class PeriodTestTableConfiguration : IEntityTypeConfiguration<PeriodTestTable>
    {
        public void Configure(EntityTypeBuilder<PeriodTestTable> builder)
        {
            builder.ToTable("PeriodTestTable", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__PeriodTe__3213E83F9E7D892C").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Joe46Bloggs).HasColumnName(@"joe.bloggs").HasColumnType("int").IsRequired(false);
        }
    }

}
// </auto-generated>
