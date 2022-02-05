// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6EfrpgTest
{
    // Harish3485
    public class Beta_Harish3485Configuration : IEntityTypeConfiguration<Beta_Harish3485>
    {
        public void Configure(EntityTypeBuilder<Beta_Harish3485> builder)
        {
            builder.ToTable("Harish3485", "Beta");
            builder.HasKey(x => x.Id).HasName("PK__Harish34__3213E83FC13C283D").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.AnotherId).HasColumnName(@"another_id").HasColumnType("int").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.PropertyTypesToAdd).WithMany(b => b.Beta_Harish3485).HasForeignKey(c => c.AnotherId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Harish");
        }
    }

}
// </auto-generated>
