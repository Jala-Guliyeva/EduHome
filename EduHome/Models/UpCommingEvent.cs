using System;
using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class UpCommingEvent
    {
        public int Id { get; set; }
        [Required]
        public DateTime Month { get; set; }
        [Required]
        public DateTime Day { get; set; }
        [Required]

        [MaxLength(10, ErrorMessage = "10den cox olmamalidi")]
        public string Title { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
    }
}
