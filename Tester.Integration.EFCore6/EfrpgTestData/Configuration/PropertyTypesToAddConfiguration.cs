// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6EfrpgTest
{
    // PropertyTypesToAdd
    public class PropertyTypesToAddConfiguration : IEntityTypeConfiguration<PropertyTypesToAdd>
    {
        public void Configure(EntityTypeBuilder<PropertyTypesToAdd> builder)
        {
            builder.ToTable("PropertyTypesToAdd", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__Property__3213E83F7CBC6D80").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.DtDefault).HasColumnName(@"dt_default").HasColumnType("datetime2").IsRequired(false);
            builder.Property(x => x.Dt7).HasColumnName(@"dt7").HasColumnType("datetime2").IsRequired(false);
            builder.Property(x => x.DefaultCheck).HasColumnName(@"defaultCheck").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
