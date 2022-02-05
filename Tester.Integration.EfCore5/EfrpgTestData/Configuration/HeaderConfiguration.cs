// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5EfrpgTest
{
    // header
    public class HeaderConfiguration : IEntityTypeConfiguration<Header>
    {
        public void Configure(EntityTypeBuilder<Header> builder)
        {
            builder.ToTable("header", "dbo");
            builder.HasKey(x => new { x.Id, x.AnotherId }).HasName("PK__header__FAB049E70F942ACD").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.AnotherId).HasColumnName(@"anotherID").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.Added).HasColumnName(@"added").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
