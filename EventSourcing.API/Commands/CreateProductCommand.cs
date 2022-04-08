using System;
using EventSourcing.API.DTOs;
using MediatR;

namespace EventSourcing.API.Commands
{
    public class CreateProductCommand : IRequest
    {
        public CreateProductDTO CreateProductDto { get; set; }
    }
}
