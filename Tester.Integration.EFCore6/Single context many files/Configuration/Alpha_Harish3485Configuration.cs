// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EFCore6.Single_context_many_files
{
    // Harish3485
    public class Alpha_Harish3485Configuration : IEntityTypeConfiguration<Alpha_Harish3485>
    {
        public void Configure(EntityTypeBuilder<Alpha_Harish3485> builder)
        {
            builder.ToTable("Harish3485", "Alpha");
            builder.HasKey(x => x.Id).HasName("PK__Harish34__3213E83F9B8F57DF").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.HarishId).HasColumnName(@"harish_id").HasColumnType("int").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.FkTest_SmallDecimalTestAttribute).WithMany(b => b.Alpha_Harish3485).HasForeignKey(c => c.HarishId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Harish");
        }
    }

}
// </auto-generated>
