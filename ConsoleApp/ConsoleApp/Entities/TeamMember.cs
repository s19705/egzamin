using System.Collections.Generic;

namespace ConsoleApp.Entities
{
    public class TeamMember
    {
        public int IdTeamMember { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

        public TeamMember()
        {
            this.Tasks = new HashSet<Task>();
        }
    }
}