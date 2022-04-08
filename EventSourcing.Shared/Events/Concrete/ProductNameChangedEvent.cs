using System;
using EventSourcing.Shared.Events.Abstract;

namespace EventSourcing.Shared.Events.Concrete
{
    public class ProductNameChangedEvent : IEvent
    {
        public Guid Id { get; set; }
        public string ChangedName { get; set; }
    }
}
