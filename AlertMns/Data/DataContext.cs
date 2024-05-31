using AlertMns.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlertMns.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkTime> WorkTimes { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        // Modifications pour la migration initiale
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    
        //}
    }
}

