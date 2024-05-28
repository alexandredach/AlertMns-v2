using AlertMns.Models;

namespace AlertMns.ViewModels
{
    public class UserViewModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int CompanyId { get; set; }
        public int PositionId { get; set; }
        public int RoleId { get; set; }
        public List<Company> Companies { get; set; }
        public List<Position> Positions { get; set; }
        public List<Role> Roles { get; set; }

        public UserViewModel()
        {
            Companies = new List<Company>();
            Positions = new List<Position>();
            Roles = new List<Role>();
        }
    }
}
