// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
{
    // DSOpe
    public class DsOpeConfiguration : IEntityTypeConfiguration<DsOpe>
    {
        public void Configure(EntityTypeBuilder<DsOpe> builder)
        {
            builder.ToTable("DSOpe", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__DSOpe__3214EC27D822B5B7").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DecimalDefault).HasColumnName(@"decimal_default").HasColumnType("decimal(15,2)").IsRequired();
            builder.Property(x => x.MyGuid).HasColumnName(@"MyGuid").HasColumnType("uniqueidentifier").IsRequired();
            builder.Property(x => x.@Default).HasColumnName(@"default").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
            builder.Property(x => x.MyGuidBadDefault).HasColumnName(@"MyGuidBadDefault").HasColumnType("uniqueidentifier").IsRequired(false);
        }
    }

}
// </auto-generated>
