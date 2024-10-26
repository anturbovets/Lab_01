using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbovets.TaskPlanner.Domain.Models.Enums;

namespace Turbovets.TaskPlanner.Domain.Models
{
    public class WorkItem
    {
        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
        public Complexity Complexity { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsComplited { get; set; }


        public string ToString()
        {
            return $"{Title}: due {DueDate:dd.MM.yyyy}, {Priority.ToString().ToLower()}";
        }
    }

}
