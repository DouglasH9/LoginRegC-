using Microsoft.EntityFrameworkCore;

namespace LoginRegC_.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<User> Users {get; set;}
    }
}