using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoralTestTask.Models;
using Microsoft.EntityFrameworkCore;

namespace CoralTestTask.Data
{
    public class CoralDbContext : DbContext
    {
        public DbSet<UserContactInfo> UserContactInfos { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public UserBusinessArea UserBusinessArea { get; set; }

        public DbSet<User> Users { get; set; }

        public CoralDbContext(DbContextOptions<CoralDbContext> contextOptions) : base(contextOptions)
        {
            Database.EnsureCreated();
        }
    }
}
