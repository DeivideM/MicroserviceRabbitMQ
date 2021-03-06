﻿using System;
using System.Collections.Generic;
using System.Text;
using MicroserviceRabbitMQ.Domain.Core.Events;
using Microsoft.VisualBasic;

namespace MicroserviceRabbitMQ.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
