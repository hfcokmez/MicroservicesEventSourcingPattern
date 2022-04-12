using System;
using EventSourcing.API.DTOs;
using EventSourcing.Shared.Events.Concrete;
using EventStore.ClientAPI;

namespace EventSourcing.API.EventStores
{
    public class ProductStream : StreamBase
    {
        public static string StreamName => "ProductStream";
        public ProductStream(IEventStoreConnection eventStoreConnection) : base(StreamName, eventStoreConnection)
        {
        }

        public void Created(CreateProductDTO createProduct)
        {
            Events.AddLast(new ProductCreatedEvent
            {
                Id = Guid.NewGuid(),
                Name = createProduct.Name,
                Price = createProduct.Price,
                Stock = createProduct.Stock,
                UserId = createProduct.UserId
            });
        }
        public void NameChanged(ChangeProductNameDTO changeProductName)
        {
            Events.AddLast(new ProductNameChangedEvent
            {
                Id = changeProductName.Id,
                ChangedName = changeProductName.Name
            });
        }
        public void PriceChanged(ChangeProductPriceDTO changeProductPrice)
        {
            Events.AddLast(new ProductPriceChangedEvent
            {
                Id = changeProductPrice.Id,
                ChangedPrice = changeProductPrice.Price
            });
        }
        public void Deleted(Guid id)
        {
            Events.AddLast(new ProductDeletedEvent{ Id = id });
        }
         
    }
}
