using Microsoft.EntityFrameworkCore;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using Newtonsoft.Json;

namespace Project_X
{
    public class DatabaseConnection
    {
        private static readonly string Host = "185.221.196.71";
        private static readonly string Port = "5432";
        private static readonly string Database = "roleplay";
        private static readonly string Login = "RolePlay";
        private static readonly string Password = "RolePlay11223344";

        public static string ConnectionString => $"Host={Host};Port={Port};Database={Database};Uid={Login};Password={Password};";
    }

    public class ApplicationContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(DatabaseConnection.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Ignore<Item>();

            modelBuilder
               .Entity<Character>()
               .Property(c => c.Inventory)
               .HasConversion(
                   i => JsonConvert.SerializeObject(i),
                   i => JsonConvert.DeserializeObject<List<Item>>(i) 
               );
            modelBuilder.Entity<Character>()
                .OwnsOne(c => c.Finance);
*/
        }
    }
}
