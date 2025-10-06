using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using Products.Domain;
using Products.Domain.Products.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Products.Commands.Create
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, ProductResDto>
    {
        private readonly IWriteUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<AddProductCommandHandler> _logger;

        public AddProductCommandHandler(IWriteUnitOfWork unitOfWork, IMapper mapper, ILogger<AddProductCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ProductResDto> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var newProduct = _mapper.Map<Domain.Products.Product>(request);
            var addedProduct = await _unitOfWork.ProductWriteRepository.AddProduct(newProduct);
            _logger.LogInformation("Product added with ID: {ProductId}", addedProduct.Id);
            return _mapper.Map<ProductResDto>(addedProduct);
        }
    }
}
