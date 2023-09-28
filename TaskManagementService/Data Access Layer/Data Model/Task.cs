namespace TaskManagementService.Data_Access_Layer.Data_Model;

public enum TaskStatus
{
    Pending,
    Completed,
    Accepted,
    Rejected
}

public enum TaskPriority
{
    Low,
    Medium,
    High
}
public class Task
{
    public int TaskId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public TaskStatus Status { get; set; }
    public TaskPriority Priority { get; set; }
    public DateTime CreatedAt { get; set; }
}

