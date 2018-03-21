using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace WebApp.Models
{
    public class WebAppContext : DbContext
    {
        public WebAppContext (DbContextOptions<WebAppContext> options)
            : base(options)
        {
        }

        public DbSet<Domain.Event> Events { get; set; }

        public DbSet<Domain.Participant> Participants { get; set; }

        public DbSet<Domain.Person> People { get; set; }

        public DbSet<Domain.Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Participant>().ToTable("Participant");
            modelBuilder.Entity<Company>().ToTable("Companies");
            modelBuilder.Entity<Person>().ToTable("Person");

        }


    }
}
