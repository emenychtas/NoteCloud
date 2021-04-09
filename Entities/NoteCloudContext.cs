using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteCloud.Entities
{
    public class NoteCloudContext : DbContext
    {
        // Entities
        public DbSet<Note> Notes { get; set; }

        // Configuration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=notecloud;Trusted_Connection=True;");
        }
    }
}
