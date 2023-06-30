using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace ConsoleApp.Entities.Configurations
{
    public class TaskTypeEfConfiguration : IEntityTypeConfiguration<TaskType>
    {
        public void Configure(EntityTypeBuilder<TaskType> builder)
        {
            builder.HasKey(e => e.IdTaskType)
                    .HasName("TaskType_pk");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.ToTable("TaskType");
            IEnumerable<TaskType> TaskTypes = new List<TaskType>();
            builder.HasData(TaskTypes);
        }
    }
}