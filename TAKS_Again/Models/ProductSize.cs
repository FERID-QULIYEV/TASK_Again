using TAKS_Again.Models.Base;
namespace TAKS_Again.Models
{
    public class ProductSize : BaseData
    {
        public int ProductId { get; set; }
        public int SizeId { get; set; }
        public Size? Size { get; set; }
        public Product? Product { get; set; }
    }
}
