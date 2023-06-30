using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace ConsoleApp.Entities.Configurations
{
    public class ProjectEfConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(e => e.IdProject).HasName("Project_pk");

            builder.Property(e => e.Name)
                        .IsRequired()
                        .HasMaxLength(100);

            builder.Property(e => e.Deadline).IsRequired()
                .HasColumnType("datetime");
            
            builder.ToTable("Project");
            IEnumerable<Project> Projects = new List<Project>();
            builder.HasData(Projects);
        }
    }
}