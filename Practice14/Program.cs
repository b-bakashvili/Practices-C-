using Practice14.Models;
using Practice14.Services;

TaskService taskService = new TaskService();

bool isOver = false;

while (!isOver)
{
    Console.WriteLine("0. Exit Program");
    Console.WriteLine("1. CreateTask");
    Console.WriteLine("2. GetAllTasks");
    Console.WriteLine("3. UpdateTask");
    Console.WriteLine("4. ChangeStatus");
    Console.WriteLine("5. DeleteTask");
    Console.WriteLine("6. FilterByStatus");
    Console.WriteLine("7. GetLogsForTask");

    Console.Write("Enter your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 0:
            isOver = true;
            Console.WriteLine("Exited Program!");
            break;
        case 1:
            Console.Write("Enter title for task: ");
            string title = Console.ReadLine();

            Console.Write("Enter description for task: ");
            string description = Console.ReadLine();

            taskService.CreateTask(title, description);
            Console.WriteLine("\n\n");
            break;
        case 2:
            List<TaskItem> tasks = taskService.GetAllTasks();

            foreach(var t in tasks)
            {
                Console.WriteLine($"Id: {t.Id}, Title: {t.Title}, Description: {t.Description}, " +
                                  $"Status: {t.Status}, Create Date: {t.Date}");
            }
            Console.WriteLine("\n\n");
            break;
        case 3:
            Console.Write("Enter Id of task: ");
            Guid id = Guid.Parse(Console.ReadLine());

            Console.Write("Enter new title for task: ");
            string newTitle = Console.ReadLine();

            Console.WriteLine("Enter new description for task: ");
            string newDescription = Console.ReadLine();

            taskService.UpdateTask(id, newTitle, newDescription);

            Console.WriteLine("\n\n");
            break;
        case 4:
            Console.Write("Enter Id of task: ");
            id = Guid.Parse(Console.ReadLine());

            Console.WriteLine("1. ToDo");
            Console.WriteLine("2. InProgress");
            Console.WriteLine("3. Testing");
            Console.WriteLine("4. Done");
            Console.Write("Enter your choice of status for task: ");

            choice = Convert.ToInt32(Console.ReadLine());

            TaskStatus status = (TaskStatus)(choice - 1);

            taskService.ChangeStatus(id, status);

            Console.WriteLine("\n\n");
            break;
        case 5:
            Console.Write("Enter Id of task: ");
            id = Guid.Parse(Console.ReadLine());

            taskService.DeleteTask(id);

            Console.WriteLine("\n\n");
            break;
        case 6:
            Console.WriteLine("1. ToDo");
            Console.WriteLine("2. InProgress");
            Console.WriteLine("3. Testing");
            Console.WriteLine("4. Done");
            Console.Write("Enter your choice of status to filter tasks: ");

            choice = Convert.ToInt32(Console.ReadLine());

            status = (TaskStatus)(choice - 1);

            List<TaskItem> filteredTasks = taskService.FilterByStatus(status);

            foreach (var t in filteredTasks)
            {
                Console.WriteLine($"Id: {t.Id}, Title: {t.Title}, Description: {t.Description}, " +
                                  $"Status: {t.Status}, Create Date: {t.Date}");
            }
            Console.WriteLine("\n\n");
            break;
        case 7:
            Console.Write("Enter Id of task: ");
            id = Guid.Parse(Console.ReadLine());

            List<Log> taskLogs = taskService.GetLogsForTask(id);

            foreach (var l in taskLogs)
            {
                Console.WriteLine($"Id: {l.Id}, TaskId: {l.TaskId}, ActionType: {l.ActionType}, " +
                                  $"Message: {l.Message}, Date: {l.Timestamp}");
            }
            Console.WriteLine("\n\n");
            break;
    }
}





// now i need to test my code, if you can't test the code you wrote
// than you have no idea what you wrote - wise man