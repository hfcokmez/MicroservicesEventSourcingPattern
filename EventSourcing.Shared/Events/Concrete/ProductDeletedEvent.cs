using System;
using EventSourcing.Shared.Events.Abstract;

namespace EventSourcing.Shared.Events.Concrete
{
    public class ProductDeletedEvent : IEvent
    {
        public Guid Id { get; set; }
    }
}
