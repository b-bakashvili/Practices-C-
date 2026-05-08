using Practice14.Models;

namespace Practice14.Services;

// we created FileService to work with files and now we will use methods
// from FileService in TaskService
internal class TaskService
{
    // fields for TaskService
    private List<TaskItem> tasks;
    private List<Log> logs;

    // i need FileService object to connect to files (to use our FileService methods)
    private FileService fileService;

    // constructor for TaskService
    public TaskService()
    {
        fileService = new FileService();

        tasks = fileService.ReadTasks();
        logs = fileService.ReadLogs();
    }

    // Methods:
    public void CreateTask(string title, string description)
    {
        TaskItem task = new TaskItem(title, description);

        tasks.Add(task);
        fileService.WriteTasks(tasks);
        AddLog(task.Id, ActionType.Created, "Task Created");
    }

    public List<TaskItem> GetAllTasks()
    {
        tasks = fileService.ReadTasks();
        return tasks;
    }

    public TaskItem GetTaskById(Guid taskId)
    {
        tasks = fileService.ReadTasks();

        foreach (var task in tasks)
        {
            if (taskId == task.Id)
            {
                return task;
            }
        }
        return null;
    }

    public void UpdateTask(Guid taskId, string newTitle, string newDescription)
    {
        tasks = fileService.ReadTasks();

        foreach (var task in tasks)
        {
            if (taskId == task.Id)
            {
                task.Title = newTitle;
                task.Description = newDescription;

                fileService.WriteTasks(tasks);

                AddLog(task.Id, ActionType.Updated, "Task Updated");

                return;
            }
        }
        Console.WriteLine("Task not found!");
    }

    public void ChangeStatus(Guid taskId, TaskStatus newStatus)
    {
        tasks = fileService.ReadTasks();
        foreach (var task in tasks)
        {
            if (taskId == task.Id)
            {
                task.Status = newStatus;

                fileService.WriteTasks(tasks);

                AddLog(task.Id, ActionType.StatusChanged, "Status Changed");

                return;
            }
        }
        Console.WriteLine("Task not found!");
    }

    public void DeleteTask(Guid taskId)
    {
        tasks = fileService.ReadTasks();

        foreach (var task in tasks)
        {
            if (taskId == task.Id)
            {
                tasks.Remove(task);

                fileService.WriteTasks(tasks);

                AddLog(task.Id, ActionType.Deleted, "Task Deleted");

                return;
            }
        }
        Console.WriteLine("Task not found!");
    }

    public List<TaskItem> FilterByStatus(TaskStatus status)
    {
        tasks = fileService.ReadTasks();

        List<TaskItem> result = new List<TaskItem>();

        foreach (var task in tasks)
        {
            if (task.Status == status)
            {
                result.Add(task);
            }
        }

        return result;
    }

    public List<Log> GetLogsForTask(Guid taskId)
    {
        tasks = fileService.ReadTasks();

        List<Log> result = new List<Log>();

        foreach (var log in logs)
        {
            if (log.TaskId == taskId)
            {
                result.Add(log);
            }
        }

        return result;
    }

    private void AddLog(Guid taskId, ActionType actionType, string message)
    {
        Log log = new Log(taskId, actionType, message);

        logs.Add(log);
        fileService.WriteLogs(logs);

        Console.WriteLine($"Log: {actionType} - {message}");
    }
}
