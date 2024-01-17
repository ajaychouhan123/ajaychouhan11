using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ajaychouhan11.Model;
using System;

namespace ajaychouhan11.Data
{
    public class ajaychouhan11Context : DbContext
    {
        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Ajay_Chouhan;Persist Security Info=True;user id=sa;password=12345;Integrated Security=true;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}