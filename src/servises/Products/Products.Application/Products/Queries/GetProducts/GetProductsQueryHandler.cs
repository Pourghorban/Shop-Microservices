using AutoMapper;
using MediatR;
using Products.Domain;
using Products.Domain.Products.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Products.Queries.GetProducts
{
    class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, ProductResDto>
    {
        private readonly IReadUnitOfWork _readUnitOfWork;
        private readonly IMapper _mapper;

        public GetProductsQueryHandler(IReadUnitOfWork readUnitOfWork, IMapper mapper)
        {
            _readUnitOfWork = readUnitOfWork;
            _mapper = mapper;
        }

        public async Task<ProductResDto> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var product = await _readUnitOfWork.ProductReadRepository.GetAsync(request.Id);
            return  _mapper.Map<ProductResDto>(product);
        }
    }
}
