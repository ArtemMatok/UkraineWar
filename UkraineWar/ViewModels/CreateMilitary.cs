using UkraineWar.Data.Enum;

namespace UkraineWar.ViewModels
{
    public class CreateMilitary
    {
        public int MilitaryEquipmentId { get; set; }

        public string Title { get; set; }
        public Country Country { get; set; }    
        public TypeOfMilitary Type { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public IFormFile Image { get; set; }
    }
}
