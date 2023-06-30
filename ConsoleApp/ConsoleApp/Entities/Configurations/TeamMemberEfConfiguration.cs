using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace ConsoleApp.Entities.Configurations
{
    public class TeamMemberEfConfiguration : IEntityTypeConfiguration<TeamMember>
    {
        public void Configure(EntityTypeBuilder<TeamMember> builder)
        {
            builder.HasKey(e => e.IdTeamMember)
                      .HasName("TeamMember_pk");
            
            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.ToTable("TeamMember");
            IEnumerable<TeamMember> TeamMembers = new List<TeamMember>();
            builder.HasData(TeamMembers);
        }
    }
}