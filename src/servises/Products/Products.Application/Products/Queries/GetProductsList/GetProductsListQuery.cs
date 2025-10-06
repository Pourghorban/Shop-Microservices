using MediatR;
using Products.Domain.Products.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Products.Queries.GetProductsList
{
    public class GetProductsListQuery : IRequest<List<ProductResDto>>
    {
    }
}
