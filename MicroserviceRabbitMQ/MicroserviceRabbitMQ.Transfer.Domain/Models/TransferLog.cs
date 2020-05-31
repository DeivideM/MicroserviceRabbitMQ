﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MicroserviceRabbitMQ.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int TransferId { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
