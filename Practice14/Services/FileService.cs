using Practice14.Models;
using System.Text.Json;
using System;
using System.Xml.Linq;
namespace Practice14.Services;

// GLOBAL KNOWLEDGE (you should know): 
// JSON (JavaScript Object Notation) is a text format to store or send data.

// What is Serialization?
//JSON = text version of your object
//Serialization = converting a C# object → JSON string
//Deserialization = converting JSON string → C# object

// only this class should work with files meaning that this service contains everything that
// we have to do to files if it doesn't then we can add new methods
internal class FileService
{
    // fields
    private const string tasksJson = "Tasks.json";
    private const string logsJson = "Logs.json";

    // Methods
    public List<TaskItem> ReadTasks()
    {
        if (!File.Exists(tasksJson) || string.IsNullOrWhiteSpace(File.ReadAllText(tasksJson)))
        {
            File.WriteAllText(tasksJson, "[]");
        }

        string data = File.ReadAllText(tasksJson);
        List<TaskItem> tasks = JsonSerializer.Deserialize<List<TaskItem>>(data);

        return tasks;
    }

    public void WriteTasks(List<TaskItem> tasks)
    {
        // true means append, false means overwrite basically
        using (StreamWriter sw = new StreamWriter(tasksJson, false))
        {
            sw.WriteLine(JsonSerializer.Serialize(tasks));
        }
    }

    public List<Log> ReadLogs()
    {
        if (!File.Exists(logsJson) || string.IsNullOrWhiteSpace(File.ReadAllText(logsJson)))
        {
            File.WriteAllText(logsJson, "[]");
        }

        string data = File.ReadAllText(logsJson);
        List<Log> logs = JsonSerializer.Deserialize<List<Log>>(data);

        return logs;
    }

    public void WriteLogs(List<Log> logs)
    {
        // true means append, false means overwrite basically
        using (StreamWriter sw = new StreamWriter(logsJson, false))
        {
            sw.WriteLine(JsonSerializer.Serialize(logs));
        }
    }
}