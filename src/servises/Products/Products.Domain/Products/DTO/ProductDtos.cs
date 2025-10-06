using Products.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Products.DTO
{
    public class ProductDtos : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string Permalink { get; set; }
        public string CoverImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Code { get; set; }
    }

    public class ProductReqDto : ProductDtos
    {
        public int CategoryId { get; set; }
    }

    public class ProductResDto : ProductDtos
    {
        public int CategoryId { get; set; }
        public string CategoryTitle_Id { get; set; }
        public string CategoryTitle{ get; set; }
    }
    public class ProductFilterPageReqDto
    {
        public int Id { get; set; }
        public string SearchTerm { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public int CategoryId { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }


    }
}
