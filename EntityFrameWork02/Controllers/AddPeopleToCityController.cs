using EntityFrameWork02.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork02.Controllers
{
    public class AddPeopleToCityController : Controller
    {

        private readonly ApplicationDbContext _context;
        public AddPeopleToCityController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string id)
        {
            var city = _context.City.Include(x => x.People).FirstOrDefault(x => x.Id == id);

            ViewBag.Id = city.Id;
            ViewBag.City = city.Name;
            ViewBag.PostNumber = city.PostNumber;
            return View(city.People);  
        }

        public IActionResult AddPeopleToTheCity()
        {
            // en selec list skickas      den tabel skickas oxh "Id" rad ska skickas till baka "Name" rad ska visas där i view
            ViewBag.City = new SelectList(_context.City , "Id" , "Name");
            ViewBag.People = new SelectList(_context.Person, "Id", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPeopleToTheCity(string id , string cityid)
        {
            var city = _context.City.Include(x => x.People).FirstOrDefault(x => x.Id == cityid);
            var person = _context.Person.Find(id);

            // om inte finns personer med samma id i lista 
            if(!city.People.Any(x=>x.Id== id))
            {
                city.People.Add(person);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.City = new SelectList(_context.City, "Id", "Name");
                ViewBag.People = new SelectList(_context.Person.Where(x=>x.Id!=id), "Id", "Name");
                ViewBag.Message = $"This person : {person.Name} >> ID : [{person.Id}] ";
                ViewBag.Message1 = $"Exist in this City : {city.Name} >> Post Number {city.PostNumber}:";
                return View();
            }

            return RedirectToAction("Index", new { id = cityid });
        }

        public IActionResult RemovePersonAvCity(string id, string cityid)
        {
            var city = _context.City.Include(x => x.People).FirstOrDefault(x => x.Id == cityid);
            var person = _context.Person.Find(id);
            city.People.Remove(person);
            _context.SaveChanges();
            return RedirectToAction("Index" , new {id = cityid});   
        }

    }
}
