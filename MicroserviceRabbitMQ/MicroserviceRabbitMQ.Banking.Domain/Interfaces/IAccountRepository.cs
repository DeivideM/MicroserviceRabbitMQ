using System;
using System.Collections.Generic;
using System.Text;
using MicroserviceRabbitMQ.Banking.Domain.Models;

namespace MicroserviceRabbitMQ.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();

    }
}
