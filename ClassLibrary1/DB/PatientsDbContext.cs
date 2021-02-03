using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.DB
{
    public class PatientsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-59EBKJC;Initial Catalog=PatientsBeta3; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(new Patient { Id = 1 ,Name = "Test", Surname = "User", dateOfBirth = new DateTime(2015, 1, 2), Diagnosis = "Apendix" });
        }

        public DbSet<Patient> Patients { get; set; }
    }
}
