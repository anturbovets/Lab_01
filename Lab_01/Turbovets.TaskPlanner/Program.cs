using Turbovets.TaskPlanner.ConsoleRunner.Services;
using Turbovets.TaskPlanner.Domain.Logic;
using Turbovets.TaskPlanner.Domain.Models;

internal static class Program
{
    public static void Main(string[] args)
    {
        SimpleTaskPlanner simpleTaskPlanner = new SimpleTaskPlanner();
        var workItemList = new List<WorkItem>();

        while (true) 
        {
            Console.WriteLine("Menu:\n" +
                            "1. Create Task\n" +
                            "2. Tasks\n");

            var input = Int32.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Enter Task info: ");
                    CreateWorkItemService createWorkItemService = new CreateWorkItemService();
                    var workItem = createWorkItemService.GetWorkItem();
                    workItemList.Add(workItem);
                    break;
                case 2:
                    Console.Clear();
                    var workItemArray = simpleTaskPlanner.CreatePlan(workItemList.ToArray());
                    foreach (var item in workItemArray)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    Console.WriteLine();
                    break;
            }
        }
        
            

    }
}
