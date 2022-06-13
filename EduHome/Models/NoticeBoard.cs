using System;
using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class NoticeBoard
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage ="50den boyuk ola bilmez")]
        public string Description { get; set; }
    }
}
