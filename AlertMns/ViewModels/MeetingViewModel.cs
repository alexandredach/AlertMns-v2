using AlertMns.Models;

namespace AlertMns.ViewModels
{
    public class MeetingViewModel
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string Status { get; set; }

        //public UserViewModel()
        //{
        //    Companies = new List<Company>();
        //    Positions = new List<Position>();
        //    Roles = new List<Role>();
        //}
    }
}
