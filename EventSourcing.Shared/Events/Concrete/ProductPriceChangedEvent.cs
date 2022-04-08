using System;
using EventSourcing.Shared.Events.Abstract;

namespace EventSourcing.Shared.Events.Concrete
{
    public class ProductPriceChangedEvent : IEvent
    {
        public Guid Id { get; set; }
        public decimal ChangedPrice { get; set; }
    }
}
