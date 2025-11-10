using BetweenSides1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenSides1.Context
{
    public class ApplicationDbContext : DbContext
    {
        // 🧭 تحديد الاتصال بقاعدة البيانات
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // ✅ اتصال محلي بقاعدة بيانات SQL Server
                string connectionString =
                    "Server=localhost\\MSSQLSERVER08;" +
                    "Database=BetweenSidesDb2;" +
                    "Integrated Security=True;" +
                    "TrustServerCertificate=True;" +
                    "Encrypt=False;" +
                    "Connect Timeout=30;";

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        // 🧩 الجداول (Entities)
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<Defendant> Defendants { get; set; }
    }
}