// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EFCore6.Single_context_many_files
{
    // table with space
    public class TableWithSpaceConfiguration : IEntityTypeConfiguration<TableWithSpace>
    {
        public void Configure(EntityTypeBuilder<TableWithSpace> builder)
        {
            builder.ToTable("table with space", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__table wi__3213E83F9E008E27").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().ValueGeneratedNever();
        }
    }

}
// </auto-generated>
