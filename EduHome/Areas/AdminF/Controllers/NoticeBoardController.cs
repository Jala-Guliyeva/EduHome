using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Areas.AdminF.Controllers
{
    [Area("AdminF")]
    public class NoticeBoardController : Controller
    {
        private AppDbContext _context;
        public NoticeBoardController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<NoticeBoard> noticeBoards = _context.NoticeBoards.ToList();
        
            return View(noticeBoards);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            NoticeBoard dbNoticeBoard = await _context.NoticeBoards.FindAsync(id);
            if (dbNoticeBoard == null) return NotFound();
            return View(dbNoticeBoard);
        }
       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            NoticeBoard dbNoticeBoard = await _context.NoticeBoards.FindAsync(id);
            if (dbNoticeBoard == null) return NotFound();
            _context.NoticeBoards.Remove(dbNoticeBoard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
