using EntityFrameWork02.Data;
using EntityFrameWork02.Models;
using EntityFrameWork02.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWork02.Controllers
{
    public class CityController : Controller
    {
        private CityVM vm = new CityVM();
        private readonly ApplicationDbContext _context;

        public CityController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            vm.Cities = _context.City.ToList();
            return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(City city)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                city.Id = Guid.NewGuid().ToString();
                city.Register = DateTime.Now;
                _context.City.Add(city);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            ViewBag.Message = "Somethings wrong ! tray again leater !";
            return View();
        }
        public IActionResult Edit(string id)
        {

            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(City city)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            _context.City.Update(city);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var city = _context.City.FirstOrDefault(x => x.Id == id);
            List<City> list = new List<City>();
            list.Add(city);
            vm.Cities = list;
            return View("Index", vm);
        }

        public IActionResult Delete(string Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var city = _context.City.FirstOrDefault(x => x.Id == Id);
            if (city != null)
            {
                _context.City.Remove(city);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
