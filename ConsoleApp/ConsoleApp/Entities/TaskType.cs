using System.Collections.Generic;

namespace ConsoleApp.Entities
{
    public class TaskType
    {
        public int IdTaskType{ get; set; }
        public string Name { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
        public TaskType()
        {
            this.Tasks = new HashSet<Task>();
        }
    }
}