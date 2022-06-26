using EduHome.DAL;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EduHome.Controllers
{
    public class EventController : Controller
    {
        private AppDbContext _context;
        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            EventVM eventVM = new EventVM();
            eventVM.events = _context.Events.ToList();

            return View(eventVM);
          
        }
    }
}
