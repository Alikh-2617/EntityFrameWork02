using EntityFrameWork02.Data;
using EntityFrameWork02.Models;
using EntityFrameWork02.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWork02.Controllers
{
    public class LanguageController : Controller
    {
        private LanguageVM vm = new LanguageVM();
        private readonly ApplicationDbContext _context;
        public LanguageController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            vm.Languagies = _context.Language.ToList();
            return View(vm);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Language language)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                language.Id = Guid.NewGuid().ToString();
                _context.Language.Add(language);
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
        public IActionResult Edit(Language language)
        {
            if (ModelState.IsValid)
            {
                _context.Language.Update(language);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }



        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var language = _context.Language.FirstOrDefault(x => x.Id == id);
            List<Language> list = new List<Language>();
            list.Add(language);
            vm.Languagies = list;
            return View("Index", vm);
        }

        public IActionResult Delete(string Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var language = _context.Language.FirstOrDefault(x => x.Id == Id);
            if (language != null)
            {
                _context.Language.Remove(language);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return NotFound();
        }


    }
}
