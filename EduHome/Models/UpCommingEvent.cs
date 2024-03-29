﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class UpCommingEvent
    {
        public int Id { get; set; }
   
        public DateTime Month { get; set; }
      
        public DateTime Day { get; set; }

       
        [Required(ErrorMessage ="dont empty"),StringLength(20,ErrorMessage ="20den cox ola bilmez")]
        public string Title { get; set; }
       
        public string Location { get; set; }
     
        public DateTime StartTime { get; set; }
       
        public DateTime EndTime { get; set; }
    }
}
