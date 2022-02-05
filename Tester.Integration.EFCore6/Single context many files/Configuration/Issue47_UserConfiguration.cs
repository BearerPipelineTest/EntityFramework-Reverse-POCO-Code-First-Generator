// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EFCore6.Single_context_many_files
{
    // Users
    public class Issue47_UserConfiguration : IEntityTypeConfiguration<Issue47_User>
    {
        public void Configure(EntityTypeBuilder<Issue47_User> builder)
        {
            builder.ToTable("Users", "Issue47");
            builder.HasKey(x => x.UserId).HasName("PK__Users__1788CC4C79258B9F").IsClustered();

            builder.Property(x => x.UserId).HasColumnName(@"UserId").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
