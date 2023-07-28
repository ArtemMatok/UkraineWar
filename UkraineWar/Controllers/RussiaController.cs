using Microsoft.AspNetCore.Mvc;
using UkraineWar.Data.Enum;
using UkraineWar.Service;

namespace UkraineWar.Controllers
{
    public class RussiaController : Controller
    {
        private readonly IMilitaryRepository _military;

        public RussiaController(IMilitaryRepository military)
        {
            _military = military;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tank()
        {
            var tanks = _military.GetAllAsync()
                .Where(x => x.Type == TypeOfMilitary.Танк)
                .Where(x => x.Country == Country.росія || x.Country == Country.Обидва).ToList();
            return View(tanks);
        }

        public IActionResult Jet()
        {
            var military = _military.GetAllAsync()
                .Where(x => x.Type == TypeOfMilitary.Літак)
                .Where(x => x.Country == Country.росія || x.Country == Country.Обидва)
                .ToList();

            return View(military);
        }

        public IActionResult Helicopter()
        {
            var military = _military.GetAllAsync()
                .Where(x => x.Type == TypeOfMilitary.Гвинтокрил)
                .Where(x => x.Country == Country.росія || x.Country == Country.Обидва)
                .ToList();

            return View(military);
        }
        public IActionResult RSZO()
        {
            var military = _military.GetAllAsync()
                .Where(x => x.Type == TypeOfMilitary.РСЗО)
                .Where(x => x.Country == Country.росія || x.Country == Country.Обидва)
                .ToList();

            return View(military);
        }


        public async Task<IActionResult> Detail(int id)
        {
            var tank = await _military.GetByIdMust(id);
            return View(tank);
        }
    }
}
