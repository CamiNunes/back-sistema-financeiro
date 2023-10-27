using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SistemaFinanceiro.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFinanceiro.Infraestrutra.Configuration
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions options) : base(options)
        {

        }

        public DbSet<FinancialSystem> FinancialSystem { set; get; }
        public DbSet<UserFinancialSystem> UserFinancialSystem { set; get; }
        public DbSet<Category> Category { set; get; }
        public DbSet<Expense> Expense { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnection());
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }

        public string GetStringConnection()
        {
            return "Server=DESKTOP-IRS4H7G\\SQLEXPRESS;Database=SistemaFinanceiro;Integrated Security=False;User ID=sa;Password=8uygfe345;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            //return "Data Source=NBQSP-FC693;Initial Catalog=FINANCEIRO_2023;Integrated Security=False;User ID=sa;Password=1234;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            //return "Data Source=NBQSP-FC693;Initial Catalog=FINANCEIRO_2023;Integrated Security=True"; // Evitar
        }
    }
}
