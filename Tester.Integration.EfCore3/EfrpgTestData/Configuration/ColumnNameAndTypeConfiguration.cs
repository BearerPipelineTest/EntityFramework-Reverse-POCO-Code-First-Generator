// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
{
    // ColumnNameAndTypes
    public class ColumnNameAndTypeConfiguration : IEntityTypeConfiguration<ColumnNameAndType>
    {
        public void Configure(EntityTypeBuilder<ColumnNameAndType> builder)
        {
            builder.ToTable("ColumnNameAndTypes", "dbo");
            builder.HasKey(x => x.C36).HasName("PK_ColumnNameAndTypes").IsClustered();

            builder.Property(x => x.C36).HasColumnName(@"$").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.C37).HasColumnName(@"%").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.C163).HasColumnName(@"£").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.C38Fred36).HasColumnName(@"&fred$").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Abc4792).HasColumnName(@"abc/\").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Joe46Bloggs).HasColumnName(@"joe.bloggs").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.SimonHughes).HasColumnName(@"simon-hughes").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Description).HasColumnName(@"description").HasColumnType("varchar(20)").IsRequired().IsUnicode(false).HasMaxLength(20);
            builder.Property(x => x.SomeDate).HasColumnName(@"someDate").HasColumnType("datetime2").IsRequired();
            builder.Property(x => x.Obs).HasColumnName(@"Obs").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Obs1).HasColumnName(@"Obs1").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Obs2).HasColumnName(@"Obs2").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.Obs3).HasColumnName(@"Obs3").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
            builder.Property(x => x.@Static).HasColumnName(@"static").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.@Readonly).HasColumnName(@"readonly").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.C123Hi).HasColumnName(@"123Hi").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.Areal).HasColumnName(@"areal").HasColumnType("real").IsRequired(false);
            builder.Property(x => x.Afloat).HasColumnName(@"afloat").HasColumnType("float").IsRequired(false);
            builder.Property(x => x.Afloat8).HasColumnName(@"afloat8").HasColumnType("real").IsRequired(false);
            builder.Property(x => x.Afloat20).HasColumnName(@"afloat20").HasColumnType("real").IsRequired(false);
            builder.Property(x => x.Afloat24).HasColumnName(@"afloat24").HasColumnType("real").IsRequired(false);
            builder.Property(x => x.Afloat53).HasColumnName(@"afloat53").HasColumnType("float").IsRequired(false);
            builder.Property(x => x.Adecimal).HasColumnName(@"adecimal").HasColumnType("decimal(18,0)").IsRequired(false);
            builder.Property(x => x.Adecimal194).HasColumnName(@"adecimal_19_4").HasColumnType("decimal(19,4)").IsRequired(false);
            builder.Property(x => x.Adecimal103).HasColumnName(@"adecimal_10_3").HasColumnType("decimal(10,3)").IsRequired(false);
            builder.Property(x => x.Anumeric).HasColumnName(@"anumeric").HasColumnType("numeric(18,0)").IsRequired(false);
            builder.Property(x => x.Anumeric52).HasColumnName(@"anumeric_5_2").HasColumnType("numeric(5,2)").IsRequired(false);
            builder.Property(x => x.Anumeric113).HasColumnName(@"anumeric_11_3").HasColumnType("numeric(11,3)").IsRequired(false);
            builder.Property(x => x.Amoney).HasColumnName(@"amoney").HasColumnType("money").IsRequired(false);
            builder.Property(x => x.Asmallmoney).HasColumnName(@"asmallmoney").HasColumnType("smallmoney").IsRequired(false);
            builder.Property(x => x.Brandon).HasColumnName(@"brandon").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.GeographyType).HasColumnName(@"GeographyType").HasColumnType("geography").IsRequired(false);
            builder.Property(x => x.GeometryType).HasColumnName(@"GeometryType").HasColumnType("geometry").IsRequired(false);
        }
    }

}
// </auto-generated>
