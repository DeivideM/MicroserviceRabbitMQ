using System;
using System.Collections.Generic;
using System.Text;
using MicroserviceRabbitMQ.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroserviceRabbitMQ.Transfer.Data.Context.Map
{
    public class TransferMap : IEntityTypeConfiguration<TransferLog>
    {
        public void Configure(EntityTypeBuilder<TransferLog> builder)
        {
            builder.ToTable("Transfer");

            builder.HasKey(x => x.TransferId);

            builder.Property(x => x.FromAccount)
                .IsRequired();

            builder.Property(x => x.ToAccount)
                .IsRequired();

            builder.Property(x => x.TransferAmount)
                .IsRequired()
                .HasColumnType("money");
        }
    }
}
