using TAKS_Again.Models.Base;

namespace TAKS_Again.Models
{
    public class Size : BaseData
    {
        public string Name { get; set; }
        public ICollection<ProductSize>? ProductSizes { get; set; }
    }
}
