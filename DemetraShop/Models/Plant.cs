using System.ComponentModel.DataAnnotations;

namespace DemetraShop.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        [EnumDataType(typeof(Watering))]
        public Watering Watering { get; set; }

        [EnumDataType(typeof(Light))]
        public Light Light { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        [Required(AllowEmptyStrings = true)]
        public string ImgURL { get; set; }
    }
}
