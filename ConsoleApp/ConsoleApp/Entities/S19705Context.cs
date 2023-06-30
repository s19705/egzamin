using Microsoft.EntityFrameworkCore;
using ConsoleApp.Entities.Configurations;
using System.Reflection;

namespace ConsoleApp.Entities
{
    public class S19705Context : DbContext
    { 
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<TaskType> TaskTypes { get; set; }
        
        public virtual DbSet<TeamMember> TeamMembers { get; set; }

        public S19705Context(DbContextOptions<S19705Context> options) : base(options)
        {
        }

        protected S19705Context()
        {
        }

       protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfigurationsFromAssembly(
                typeof(TaskEfConfiguration).GetTypeInfo().Assembly);
        }
    }
}