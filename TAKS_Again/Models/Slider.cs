using TAKS_Again.Models.Base;

namespace TAKS_Again.Models
{
    public class Slider:BaseData
    {
        public string PrimaryTitle { get; set; }
        public string SecondaryTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Order { get; set; }
    }
}
