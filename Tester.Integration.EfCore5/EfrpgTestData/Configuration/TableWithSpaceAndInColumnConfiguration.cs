// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5EfrpgTest
{
    // table with space and in columns
    public class TableWithSpaceAndInColumnConfiguration : IEntityTypeConfiguration<TableWithSpaceAndInColumn>
    {
        public void Configure(EntityTypeBuilder<TableWithSpaceAndInColumn> builder)
        {
            builder.ToTable("table with space and in columns", "dbo");
            builder.HasKey(x => x.IdValue).HasName("PK__table wi__92CF061CF3030C0C").IsClustered();

            builder.Property(x => x.IdValue).HasColumnName(@"id value").HasColumnType("int").IsRequired().ValueGeneratedNever();
        }
    }

}
// </auto-generated>
