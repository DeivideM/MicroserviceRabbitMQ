using System;
using System.Collections.Generic;
using System.Text;
using MicroserviceRabbitMQ.Banking.Data.Context.Map;
using MicroserviceRabbitMQ.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroserviceRabbitMQ.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountMap());
        }

        public DbSet<Account> Accounts { get; set; }
    }
}

