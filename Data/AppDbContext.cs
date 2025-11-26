using Microsoft.EntityFrameworkCore;
using FeedbackWebApplication.Models;

namespace FeedbackWebApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<feedback> feedbacks { get; set; }
    }
}
