using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.AdminF.Controllers
{
    [Area("Adminf")]
    public class NoticeRightInfoController : Controller
    {
        private AppDbContext _context;
        public NoticeRightInfoController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<NoticeRightInfo> noticeRightInfos = _context.NoticeRightInfos.ToList();

            return View(noticeRightInfos);
            
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            NoticeRightInfo dbnoticeRightInfo = await _context.NoticeRightInfos.FindAsync(id);
            if (dbnoticeRightInfo == null) return NotFound();
            return View(dbnoticeRightInfo);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            NoticeRightInfo dbnoticeRightInfo = await _context.NoticeRightInfos.FindAsync(id);
            if (dbnoticeRightInfo == null) return NotFound();
            _context.NoticeRightInfos.Remove(dbnoticeRightInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
