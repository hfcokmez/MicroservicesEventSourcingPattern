using System;
using EventSourcing.Shared.Events.Abstract;

namespace EventSourcing.Shared.Events.Concrete
{
    public class ProductCreatedEvent : IEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public int Stock { get; set; }
    }
}
