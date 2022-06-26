using System;
using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class NoticeBoard
    {
        public int Id { get; set; }
       
        public DateTime Date { get; set; }

        public string Description { get; set; }
    }
}
