using TAKS_Again.Models.Base;

namespace TAKS_Again.Models
{
    public class Color : BaseData
    {
        public string Name { get; set; }
        public ICollection<ProductColor>? ProductColors { get; set; }
    }
}
