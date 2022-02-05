// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // table with space
    public class TableWithSpaceConfiguration : IEntityTypeConfiguration<TableWithSpace>
    {
        public void Configure(EntityTypeBuilder<TableWithSpace> builder)
        {
            builder.ToTable("table with space", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__table wi__3213E83F9E008E27").ForSqlServerIsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().ValueGeneratedNever();
        }
    }

}
// </auto-generated>
