using TAKS_Again.Models.Base;

namespace TAKS_Again.Models
{
    public class ProductInformation : BaseData
    {
        public string Shipping { get; set; }
        public string AboutReturnRequest { get; set; }
        public string Guarantee { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
