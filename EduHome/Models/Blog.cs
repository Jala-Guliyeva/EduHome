﻿using System;

namespace EduHome.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime WriteTime { get; set; }
        public int CommentCount { get; set; }
    }
}
