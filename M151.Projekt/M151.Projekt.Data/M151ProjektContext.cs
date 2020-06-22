using M151.Projekt.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace M151.Projekt.Data
{
    public class M151ProjektContext : DbContext
    {
        public M151ProjektContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
