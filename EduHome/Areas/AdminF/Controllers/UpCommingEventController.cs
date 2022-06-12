using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.AdminF.Controllers
{
    [Area("AdminF")]
    public class UpCommingEventController : Controller
    {
        private AppDbContext _context;
        public UpCommingEventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<UpCommingEvent> dbUpCommingEvents = _context.UpCommingEvents.ToList();
            return View(dbUpCommingEvents);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();

            UpCommingEvent dbUpCommingEvent =await  _context.UpCommingEvents.FindAsync(id);
            if (dbUpCommingEvent == null) return NotFound();
            return View(dbUpCommingEvent);

        }
        public async Task<IActionResult>Delete(int? id)
        {
            if (id == null) return NotFound();
            UpCommingEvent dbUpCommingEvent = await _context.UpCommingEvents.FindAsync(id);
            if (dbUpCommingEvent == null) return NotFound();
            _context.UpCommingEvents.Remove(dbUpCommingEvent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
