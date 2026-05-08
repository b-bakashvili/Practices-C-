namespace Practice14.Models;

// class was named TaskItem because Task class already exists in .net (C#)
internal class TaskItem
{
    // created fields as private (following encapsulation principle) and we will create
    // public constructors/properties to access private fields
    private Guid _id;
    private string _title;
    private string _description;
    private TaskStatus _status;
    private DateTime _createdAt;

    // public properties to acces private fields
    public Guid Id { get => _id; set => _id = value; }
    public string Title
    {
        get => _title; // same as get{ return _title; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _title = value;
            }
        }
    }
    public string Description
    {
        get => _description;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _description = value;
            }
        }
    }
    public TaskStatus Status { get => _status; set => _status = value; }
    public DateTime Date { get => _createdAt; set => _createdAt = value; }

    // created public constructor to acces create object
    public TaskItem(string title, string description)
    {
        _id = Guid.NewGuid();
        _title = title;
        _description = description;
        _status = TaskStatus.ToDo;
        _createdAt = DateTime.Now;
    }
}