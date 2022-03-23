using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteCloud.Entities
{
    public class NoteCloudContext : IdentityDbContext<NoteCloudUser>
    {
        // Entities
        public DbSet<Note> Notes { get; set; }
        public DbSet<NoteCloudUser> NoteCloudUsers { get; set; }

    //    // Configuration
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer(@"Server=localhost;Database=notecloud;Trusted_Connection=True;");
    //    }
    }
}
