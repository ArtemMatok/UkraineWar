using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Syncfusion.EJ2.Spreadsheet;
using UkraineWar.Models;
using UkraineWar.Service;
using UkraineWar.ViewModels;

namespace UkraineWar.Controllers
{
    public class MilitaryController : Controller
    {
        private readonly IMilitaryRepository _militaryRepository;
        private readonly IPhotoService _photoService;
        public MilitaryController(IMilitaryRepository militaryRepository, IWebHostEnvironment hostEnvironment, IPhotoService photoService)
        {
            _militaryRepository = militaryRepository;
            _photoService = photoService;
        }

        public async Task<IActionResult> Index()
        {
            var military = await _militaryRepository.GetAll();
            return View(military);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>Create(CreateMilitary militaryVM)
        {
            var result = await _photoService.AddPhotoAsync(militaryVM.Image);
            var military = new MilitaryEquipment()
            {
                Title = militaryVM.Title,
                Description = militaryVM.Description,
                Price = militaryVM.Price,
                Type = militaryVM.Type,
                Country = militaryVM.Country,
                Image = result.Url.ToString()
                
            };
            _militaryRepository.Add(military);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var military = await _militaryRepository.GetByIdMust(id);
            if (military == null) return View("Error");
            var militaryVM = new EditMilitary()
            { 
                Title = military.Title,
                Description = military.Description,
                Price = military.Price,
                Country = military.Country,
                Type = military.Type,
                URL = military.Image,

            };
            return View(militaryVM);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditMilitary militaryVM)
        {
            

            var userMilitary = await _militaryRepository.GetByIdAsNoTracking(id);
            if(userMilitary != null)
            {
                try
                {
                    await _photoService.DeletePhotoAsync(userMilitary.Image);

                }
                catch (Exception ex)
                {

                    ModelState.AddModelError("","Could not delete photo");
                    return View(militaryVM);
                }
                var photoResult = await _photoService.AddPhotoAsync(militaryVM.Image);

                var military = new MilitaryEquipment()
                {
                    MilitaryEquipmentId = id,
                    Title = militaryVM.Title,
                    Country = militaryVM.Country,
                    Description = militaryVM.Description,
                    Price = militaryVM.Price,
                    Type = militaryVM.Type,
                    Image = photoResult.Url.ToString(),
                };
                _militaryRepository.Update(military);
                return RedirectToAction("Index");
            }
            else
            {
                return View(militaryVM);
            }
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var military = await _militaryRepository.GetByIdMust(id);
            if (military != null)
            {
                _militaryRepository.Delete(military);
            }

            
            return RedirectToAction(nameof(Index));
        }
    }
}
