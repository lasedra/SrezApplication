using static API.DbModels;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class SrezDbContext : DbContext
    {
        public SrezDbContext(DbContextOptions<DbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
