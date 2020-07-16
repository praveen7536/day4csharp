using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace day4assignment.Models
{
    public class ApplicationdbContext: DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=PRAVEEN-PRAVEENSQL;database=mydatabaseforsql");
        }
        public DbSet<User> users { get; set; }

    }
}
