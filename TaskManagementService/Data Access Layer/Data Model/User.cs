

namespace TaskManagementService.Data_Access_Layer.Data_Model;
public class User
{
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsBlocked { get; set; }
        public User Manager { get; set; }
        public List<User> Subordinates { get; set; }
        public List<Task> Tasks { get; set; }
}

