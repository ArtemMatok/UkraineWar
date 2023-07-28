using Microsoft.AspNetCore.Mvc;

namespace UkraineWar.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult RoundedColumn()
        {
            List<RoundedColumnChartData> ChartPoints = new List<RoundedColumnChartData>
            {
                new RoundedColumnChartData { Type = "Танки",Rate = 100,   Loses = 31.0, Text = "31.0%" },
                new RoundedColumnChartData { Type = "ББМ", Rate = 100, Loses = 27.9, Text = "27.9%" },
                new RoundedColumnChartData { Type = "Літаки",Rate = 100,   Loses =22.8, Text = "22.8%" },
                new RoundedColumnChartData { Type = "Гвинтокрили",Rate = 100,  Loses = 32.4, Text = "32.4%" },
                new RoundedColumnChartData { Type = "Жива сила",  Rate = 100, Loses = 27.2, Text = "27.2%" },

            };
            ViewBag.ChartPoints = ChartPoints;
            return View();
        }
        public class RoundedColumnChartData
        {
            public string Type;
            public double Rate;
            public double Loses;
            public string Text;
        }



    }
}
