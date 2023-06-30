using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace ConsoleApp.Entities.Configurations
{
    public class TaskEfConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(e => e.IdTask).HasName("Client_pk");
            builder.Property(e => e.IdTask).UseIdentityColumn();
            builder.Property(e => e.Name).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Description).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Deadline).IsRequired();
            
            builder.HasOne(e => e.IdProjectNavigation)
               .WithMany(e => e.Tasks)
               .HasForeignKey(e => e.IdProjectNavigation)
               .HasConstraintName("Task_Project")
               .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(e => e.IdTaskTypeNavigation)
                .WithMany(e => e.Tasks)
                .HasForeignKey(e => e.IdTaskTypeNavigation)
                .HasConstraintName("Task_TaskType")
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(e => e.IdTeamMemberCreatorNavigation)
                .WithMany(e => e.Tasks)
                .HasForeignKey(e => e.IdTeamMemberCreatorNavigation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Task_TeamMember");

            builder.HasOne(e => e.IdTeamMemberAssignedToNavigation)
                 .WithMany(e => e.Tasks)
                 .HasForeignKey(e => e.IdTeamMemberAssignedToNavigation)
                 .OnDelete(DeleteBehavior.ClientSetNull)
                 .HasConstraintName("Task_TeamMember");

            builder.ToTable("Task");
            IEnumerable<Task> Tasks = new List<Task>();
            builder.HasData(Tasks);
        }
    }
}