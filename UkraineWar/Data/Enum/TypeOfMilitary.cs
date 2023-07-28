using System.ComponentModel.DataAnnotations;

namespace UkraineWar.Data.Enum
{
    public enum TypeOfMilitary
    {
        [Display(Name ="Танк")]
        Танк,
        [Display(Name = "Літак")]
        Літак,
        [Display(Name = "Гвинтокрил")]
        Гвинтокрил,
        [Display(Name = "РСЗО")]
        РСЗО
    }
}
