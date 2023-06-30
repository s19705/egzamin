using System;
using System.Collections.Generic;

namespace ConsoleApp.Entities
{
    public class Task
    {
        public int IdTask { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public virtual TaskType IdTaskTypeNavigation { get; set; }
        public virtual Project IdProjectNavigation { get; set; }
        public virtual TeamMember IdTeamMemberCreatorNavigation { get; set; }
        public virtual TeamMember IdTeamMemberAssignedToNavigation { get; set; }
    }
}