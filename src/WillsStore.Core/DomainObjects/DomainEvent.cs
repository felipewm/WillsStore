using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WillsStore.Core.Messages;

namespace WillsStore.Core.DomainObjects
{
    public class DomainEvent : Event
    {
      public DomainEvent(Guid aggregateId) 
        {
            AggregateId = aggregateId;
        }
    }
}
