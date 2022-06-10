using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.sliders= _context.Sliders.ToList();
            homeVM.pageIntros = _context.PageIntros.FirstOrDefault();
            homeVM.noticeBoards = _context.NoticeBoards.ToList();
            homeVM.noticeRightInfos = _context.NoticeRightInfos.ToList();
            homeVM.courses = _context.Courses.ToList();
            homeVM.upCommingEvents = _context.UpCommingEvents.ToList();
            homeVM.blog = _context.Blogs.ToList();
          
            return View(homeVM);
        }
    }
}
