using Microsoft.EntityFrameworkCore;
using Exam2.Models;

namespace Exam2.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users {get;set;}
        public DbSet<Activity> Activity {get;set;}
        public DbSet<Player> Players {get;set;}
    }
}