using System.Text.Json.Serialization;

namespace Practice14.Models;

internal class Log
{
    // created fields as private for encapsulation reasons and we will create
    // public constructors/properties to access private fields
    private Guid _id;
    private Guid _taskId;
    private ActionType _actionType;
    private string _message;
    private DateTime? _timestamp; // DateTime? -> same as DateTime but can also store Null value

    // public properties to acces private fields
    public Guid Id => _id;
    public Guid TaskId { get => _taskId; set => _taskId = value; }
    public ActionType ActionType { get => _actionType; set => _actionType = value; }
    public string Message
    {
        get => _message;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                _message = value;
            }
        }
    }
    public DateTime? Timestamp => _timestamp;


    // constructor
    [JsonConstructor]
    public Log(Guid taskId, ActionType actionType, string message)
    {
        _id = Guid.NewGuid();
        _taskId = taskId;
        _actionType = actionType;
        _message = message;
        _timestamp = DateTime.Now;
    }
}