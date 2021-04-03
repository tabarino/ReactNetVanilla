using System;
using Microsoft.EntityFrameworkCore;
using ReactNetVanilla.Core.Models;

namespace ReactNetVanilla.Persistence
{
    public class ReactNetDbContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }

        public ReactNetDbContext(DbContextOptions<ReactNetDbContext> options) : base(options)
        {
        }
    }
}
