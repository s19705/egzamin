using System;
using System.Collections.Generic;

namespace ConsoleApp.Entities
{
    public class Project
    {
        public int IdProject { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

        public Project()
        {
            this.Tasks = new HashSet<Task>();
        }
    }
}