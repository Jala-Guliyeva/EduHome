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
        public async Task<IActionResult> Create(UpCommingEvent upCommingEvent)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            bool isExistLocation = _context.UpCommingEvents.Any(u => u.Location.ToLower() == upCommingEvent.Location.ToLower());
            
                if (isExistLocation)
            {
                ModelState.AddModelError("Location", "eynisi var");
                return View();
            }
                
            UpCommingEvent newUpCommingEvent = new UpCommingEvent();
            newUpCommingEvent.Month = upCommingEvent.Month;
            newUpCommingEvent.Day = upCommingEvent.Day;
            newUpCommingEvent.Title = upCommingEvent.Title;
            newUpCommingEvent.Location = upCommingEvent.Location;
            newUpCommingEvent.StartTime = upCommingEvent.StartTime;
            newUpCommingEvent.EndTime = upCommingEvent.EndTime;
           await  _context.UpCommingEvents.AddAsync(newUpCommingEvent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            
        
        }
        public async Task<IActionResult>Update(int? id)
        {
            if (id == null) return NotFound();
            UpCommingEvent dbUpCommingEvent =await _context.UpCommingEvents.FindAsync(id);

            if (dbUpCommingEvent == null) return NotFound();
            return View(dbUpCommingEvent);
        }

        [HttpPost]
        public async Task<IActionResult>Update(int? id,UpCommingEvent upCommingEvent)
        {
            
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null) return NotFound();
            UpCommingEvent dbUpCommingEvent = await _context.UpCommingEvents.FindAsync(id);
            if (dbUpCommingEvent == null) return NotFound();
            dbUpCommingEvent.Month = upCommingEvent.Month;
            dbUpCommingEvent.Day = upCommingEvent.Day;
            dbUpCommingEvent.Title = upCommingEvent.Title;
            dbUpCommingEvent.Location = upCommingEvent.Location;
            dbUpCommingEvent.StartTime = upCommingEvent.StartTime;
            dbUpCommingEvent.EndTime = upCommingEvent.EndTime;
            await _context.SaveChangesAsync();
            return View(); 
        }
    }
}
