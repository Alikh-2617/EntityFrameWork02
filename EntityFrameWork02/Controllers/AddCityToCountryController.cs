using EntityFrameWork02.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork02.Controllers
{
    public class AddCityToCountryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AddCityToCountryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string id)
        {
            var country = _context.Country.Include(x=>x.City).FirstOrDefault(x=>x.Id == id);
            ViewBag.country = country.Name;
            ViewBag.id = country.Id;
            ViewBag.Register = country.Register;
            return View(country.City);
        }

        public IActionResult AddCityToCountry()
        {
            ViewBag.city = new SelectList(_context.City, "Id", "Name");
            ViewBag.country = new SelectList(_context.Country, "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCityToCountry(string id ,string countryid)
        {
            var country = _context.Country.Include(x => x.City).FirstOrDefault(x => x.Id == countryid);
            var city = _context.City.Find(id);
            if(!country.City.Any(x=>x.Id == id))
            {
                country.City.Add(city);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.city = new SelectList(_context.City.Where(x=>x.Id != id), "Id", "Name");
                ViewBag.country = new SelectList(_context.Country, "Id", "Name");
                ViewBag.Message = $"This City : {city.Name} >> {city.PostNumber}";
                ViewBag.Message1 = $"Exist in this Country : {country.Name}";
                return View();
            }

            return RedirectToAction("index", new {id = countryid});
        }

        public IActionResult RemoveCityAvCountry(string id, string countryid)
        {
            var country = _context.Country.Include(x => x.City).FirstOrDefault(x => x.Id == countryid);
            var city = _context.City.Find(id);
            country.City.Remove(city);
            _context.SaveChanges();

            return RedirectToAction("Index", new { id = countryid });
        }
    }
}
