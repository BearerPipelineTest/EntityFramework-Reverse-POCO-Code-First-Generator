// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
{
    // SmallDecimalTest
    public class SmallDecimalTestConfiguration : IEntityTypeConfiguration<SmallDecimalTest>
    {
        public void Configure(EntityTypeBuilder<SmallDecimalTest> builder)
        {
            builder.ToTable("SmallDecimalTest", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__SmallDec__3213E83FE4C159DA").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.KoeffVed).HasColumnName(@"KoeffVed").HasColumnType("decimal(4,4)").IsRequired(false);
        }
    }

}
// </auto-generated>
