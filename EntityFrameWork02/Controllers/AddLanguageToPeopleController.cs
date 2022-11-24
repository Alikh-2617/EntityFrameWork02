using EntityFrameWork02.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWork02.Controllers
{
    public class AddLanguageToPeopleController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AddLanguageToPeopleController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string id)
        {
            var person = _context.Person.Include(x => x.Languages).FirstOrDefault(x => x.Id == id);
            ViewBag.person = person.Name;
            ViewBag.personId = person.Id;
            return View(person.Languages);
        }

        public IActionResult AddLanguageToPerson()
        {
            ViewBag.People = new SelectList(_context.Person, "Id", "Name");
            ViewBag.Language = new SelectList(_context.Language, "Id", "Name");


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddLanguageToPerson(string personid , string languageid)
        {
            var person = _context.Person.Include(x=>x.Languages).FirstOrDefault(x=>x.Id == personid);
            var language = _context.Language.Find(languageid);

            if(!person.Languages.Any(x=>x.Id == languageid))
            {
                person.Languages.Add(language);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.People = new SelectList(_context.Person, "Id", "Name");
                ViewBag.Language = new SelectList(_context.Language.Where(x=>x.Id == languageid), "Id", "Name");
                ViewBag.Message = $"This person : {person.Name} have this Language : {language.Name}";
                return View();
            }

            return RedirectToAction("Index" , new {id = personid });
        }

        public IActionResult DeleteLanguageAvPerson(string id, string languageid)
        {
            var person = _context.Person.Include(x => x.Languages).FirstOrDefault(x => x.Id == id);
            var language = _context.Language.Find(languageid);
            person.Languages.Remove(language);
            _context.SaveChanges();

            return RedirectToAction("Index", new { id = id });
        }



    }
}
