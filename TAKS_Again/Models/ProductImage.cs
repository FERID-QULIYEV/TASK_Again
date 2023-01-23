using TAKS_Again.Models.Base;
namespace TAKS_Again.Models
{
    public class ProductImage : BaseData
    {
        public string ImageUrl { get; set; }
        public bool? IsCover { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
