using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using System;
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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UpCommingEvent upCommingEvent)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return Content($"{upCommingEvent.Month.ToString("MMMM")} {upCommingEvent.Day.ToString("dd")} {upCommingEvent.Title} {upCommingEvent.Location } {upCommingEvent.StartTime.ToString("hh:mm:ss")} {upCommingEvent.EndTime.ToString("hh:mm:ss")}");
            
        
        }
    }
}
