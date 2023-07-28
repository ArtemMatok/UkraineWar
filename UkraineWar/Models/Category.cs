using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UkraineWar.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; } 
        public string Title { get; set; }
        public string Icon { get; set; }
        [NotMapped]
        public string TitleWithIcon
        {
            get
            {
                return Icon + Title;
            }
        }
    }
}
