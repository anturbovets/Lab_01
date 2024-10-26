using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbovets.TaskPlanner.Domain.Models;

namespace Turbovets.TaskPlanner.Domain.Logic
{
    public class SimpleTaskPlanner
    {
        public WorkItem[] CreatePlan(WorkItem[] workItems)
        {
            var result = workItems.ToList();
            result.Sort(CompareWorkItems);
            return result.ToArray();
        }

        public int CompareWorkItems(WorkItem workItem1, WorkItem workItem2)
        {
            var priority = workItem2.Priority.CompareTo(workItem1.Priority);
            if (priority != 0)
            {
                return priority;
            }

            var dueDate = workItem1.DueDate.CompareTo(workItem2.DueDate);
            if (dueDate != 0)
            {
                return dueDate;
            }

            return string.Compare(workItem1.Title, workItem2.Title, StringComparison.OrdinalIgnoreCase);
        }
    }
}
