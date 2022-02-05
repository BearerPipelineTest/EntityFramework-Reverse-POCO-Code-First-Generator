// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EFCore6.Single_context_many_files
{
    // workflow
    public class Beta_WorkflowConfiguration : IEntityTypeConfiguration<Beta_Workflow>
    {
        public void Configure(EntityTypeBuilder<Beta_Workflow> builder)
        {
            builder.ToTable("workflow", "Beta");
            builder.HasKey(x => x.Id).HasName("PK__workflow__3214EC07B70B4182").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Description).HasColumnName(@"Description").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
