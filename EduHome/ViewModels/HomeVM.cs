using EduHome.Models;
using System.Collections;
using System.Collections.Generic;

namespace EduHome.ViewModels
{
    public class HomeVM
    {
        public IEnumerable <Slider>sliders  { get; set; }
        public PageIntro pageIntros { get; set; }
        public IEnumerable <NoticeBoard>noticeBoards { get; set; }
        public IEnumerable<NoticeRightInfo>noticeRightInfos { get; set; }
        public IEnumerable <Course>courses { get; set; }
        public IEnumerable<UpCommingEvent>upCommingEvents { get; set; }
        public IEnumerable<Blog>blog { get; set; }
    }
}
