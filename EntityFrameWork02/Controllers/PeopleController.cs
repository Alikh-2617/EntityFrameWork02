using EntityFrameWork02.Data;
using EntityFrameWork02.Models;
using EntityFrameWork02.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWork02.Controllers
{
    public class PeopleController : Controller
    {
        private PersonVM vm = new PersonVM();
        private readonly ApplicationDbContext _context;
        public PeopleController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            vm.People = _context.Person.ToList();
            return View(vm);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person person)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                person.Id = Guid.NewGuid().ToString();
                person.Register = DateTime.Now;
                _context.Person.Add(person);
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
        public IActionResult Edit(Person person)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            _context.Person.Update(person);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



        public IActionResult Details(string id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var person = _context.Person.FirstOrDefault(x=>x.Id == id);
            List<Person> list = new List<Person>();
            list.Add(person);
            vm.People = list;
            return View("Index",vm);
        }

        public IActionResult Delete(string Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var person = _context.Person.FirstOrDefault(x => x.Id == Id);
            if(person != null)
            {
                _context.Person.Remove(person);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }
}
