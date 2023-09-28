
namespace TaskManagementService.Data_Access_Layer.Data_Model;

public class ReportingLine
{
    public int Id { get; set; }
    public User Manager { get; set; }
    public User Subordinate { get; set; }
    public DateTime ChangeDate { get; set; }
    public string ChangeType { get; set; } // Added, Removed
}
