// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5EfrpgTest
{
    // UserInfoAttributes
    public class UserInfoAttributeConfiguration : IEntityTypeConfiguration<UserInfoAttribute>
    {
        public void Configure(EntityTypeBuilder<UserInfoAttribute> builder)
        {
            builder.ToTable("UserInfoAttributes", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_UserInfoAttributes").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.PrimaryId).HasColumnName(@"PrimaryId").HasColumnType("int").IsRequired();
            builder.Property(x => x.SecondaryId).HasColumnName(@"SecondaryId").HasColumnType("int").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.Primary).WithMany(b => b.UserInfoAttributes_PrimaryId).HasForeignKey(c => c.PrimaryId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_UserInfoAttributes_PrimaryUserInfo");
            builder.HasOne(a => a.Secondary).WithMany(b => b.UserInfoAttributes_SecondaryId).HasForeignKey(c => c.SecondaryId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_UserInfoAttributes_SecondaryUserInfo");
        }
    }

}
// </auto-generated>
