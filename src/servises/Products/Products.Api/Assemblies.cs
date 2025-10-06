using Products.Application.Products.Commands.Create;
using Products.Domain.Products;
using Products.Infrastructure;
using System.Reflection;

namespace Products.Api
{
    public class Assemblies
    {
        public static readonly Assembly EntityAssembly = typeof(Product).Assembly;
        public static readonly Assembly InfraStructureAssembly = typeof(ProductDbContext).Assembly;
        public static readonly Assembly ApplicationAssembly = typeof(AddProductCommand).Assembly;
    }
}
