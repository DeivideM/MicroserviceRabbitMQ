using System;
using System.Collections.Generic;
using System.Text;
using MicroserviceRabbitMQ.Banking.Data.Context;
using MicroserviceRabbitMQ.Banking.Domain.Interfaces;
using MicroserviceRabbitMQ.Banking.Domain.Models;

namespace MicroserviceRabbitMQ.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
