using System;
using System.Collections.Generic;
using System.Text;
using MicroserviceRabbitMQ.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroserviceRabbitMQ.Banking.Data.Context.Map
{
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");

            builder.HasKey(x => x.AccountId);

            builder.Property(x => x.AccountType)
                .IsRequired()
                .IsUnicode(false)
                //.HasColumnType("varchar(20")
                .HasMaxLength(20);

            builder.Property(x => x.AccountBalance)
                .IsRequired()
                .HasColumnType("money");


        }
    }
}
