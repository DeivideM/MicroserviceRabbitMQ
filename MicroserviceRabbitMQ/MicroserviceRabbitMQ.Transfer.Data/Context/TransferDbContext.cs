using System;
using System.Collections.Generic;
using System.Text;
using MicroserviceRabbitMQ.Transfer.Data.Context.Map;
using MicroserviceRabbitMQ.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroserviceRabbitMQ.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TransferMap());
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
