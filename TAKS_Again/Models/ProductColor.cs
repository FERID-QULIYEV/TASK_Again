using TAKS_Again.Models.Base;

namespace TAKS_Again.Models
{
    public class ProductColor : BaseData
    {
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public Color? Color { get; set; }
        public Product? Product { get; set; }
    }
}
