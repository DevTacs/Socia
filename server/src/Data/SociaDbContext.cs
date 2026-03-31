using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using src.Entities;


namespace src.Data
{
    public class SociaDbContext(DbContextOptions<SociaDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}