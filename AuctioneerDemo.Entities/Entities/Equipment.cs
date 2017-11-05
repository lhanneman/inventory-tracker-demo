using System.ComponentModel.DataAnnotations;

namespace AuctioneerDemo.Entities
{
    public class Equipment
    {
        [Key]
        public int EquipmentId { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
    }
}