// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6EfrpgTest
{
    // table with duplicate column names
    public class TableWithDuplicateColumnNameConfiguration : IEntityTypeConfiguration<TableWithDuplicateColumnName>
    {
        public void Configure(EntityTypeBuilder<TableWithDuplicateColumnName> builder)
        {
            builder.ToTable("table with duplicate column names", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__table wi__3213E83F6A018E91").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.UserId1).HasColumnName(@"user_id").HasColumnType("int").IsRequired();
            builder.Property(x => x.UserId2).HasColumnName(@"UserId").HasColumnType("int").IsRequired();
            builder.Property(x => x.UserId3).HasColumnName(@"User Id").HasColumnType("int").IsRequired();
            builder.Property(x => x.UserId4).HasColumnName(@"User  Id").HasColumnType("int").IsRequired();
            builder.Property(x => x.UserId).HasColumnName(@"user__id").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
