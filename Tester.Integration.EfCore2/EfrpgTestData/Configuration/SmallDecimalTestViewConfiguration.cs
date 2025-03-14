// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // SmallDecimalTestView
    public class SmallDecimalTestViewConfiguration : IEntityTypeConfiguration<SmallDecimalTestView>
    {
        public void Configure(EntityTypeBuilder<SmallDecimalTestView> builder)
        {
            builder.ToTable("SmallDecimalTestView", "dbo");
            builder.HasKey(x => new { x.FkId, x.Description });

            builder.Property(x => x.FkId).HasColumnName(@"FkID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Description).HasColumnName(@"description").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20).ValueGeneratedNever();
        }
    }

}
// </auto-generated>
