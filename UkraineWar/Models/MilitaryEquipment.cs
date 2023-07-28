using MessagePack;
using System.ComponentModel.DataAnnotations;
using UkraineWar.Data.Enum;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace UkraineWar.Models
{
    public class MilitaryEquipment
    {
        [Key]
        public int MilitaryEquipmentId { get; set; }

        public string Title { get; set; }
        public Country Country { get; set; }    
        public TypeOfMilitary Type { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}
