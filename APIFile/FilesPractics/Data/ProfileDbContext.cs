using FilesPractics.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FilesPractics.Data
{
    public class ProfileDbContext : DbContext
    {
        public ProfileDbContext(DbContextOptions<ProfileDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProfileTeacher> Teachers { get; set; }
    }
}
