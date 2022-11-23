using EntityFrameWork02.Data;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWork02.Controllers
{
    public class AddPeopleToCityController : Controller
    {

        private readonly ApplicationDbContext _context;
        public AddPeopleToCityController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
