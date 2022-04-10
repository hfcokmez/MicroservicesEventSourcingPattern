using System;
using MediatR;
using EventSourcing.API.DTOs;

namespace EventSourcing.API.Commands
{
    public class ChangeProductPriceCommand : IRequest
    {
        public ChangeProductPriceDTO ChangeProductPriceDTO { get; set; }
    }
} 
