using EntityFrameWork02.Data;
using EntityFrameWork02.Models;
using EntityFrameWork02.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWork02.Controllers
{
    public class CountryController : Controller
    {
        private CountryVM vm = new CountryVM(); 
        private readonly ApplicationDbContext _context;
        public CountryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            vm.Countries = _context.Country.ToList();
            return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Country country)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                country.Id = Guid.NewGuid().ToString();
                _context.Country.Add(country);
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
        public IActionResult Edit(Country country)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            _context.Country.Update(country);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var country = _context.Country.FirstOrDefault(x => x.Id == id);
            List<Country> list = new List<Country>();
            list.Add(country);
            vm.Countries = list;
            return View("Index", vm);
        }

        public IActionResult Delete(string Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var country = _context.Country.FirstOrDefault(x => x.Id == Id);
            if (country != null)
            {
                _context.Country.Remove(country);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
