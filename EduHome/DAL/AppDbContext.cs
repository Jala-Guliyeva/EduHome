﻿using EduHome.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EduHome.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Slider>Sliders { get; set; }
        public DbSet<PageIntro>PageIntros{ get; set; }
        public DbSet<NoticeBoard>NoticeBoards { get; set; }
        public DbSet<NoticeRightInfo>NoticeRightInfos { get; set; }
        public DbSet<Course>Courses { get; set; }
        public DbSet<UpCommingEvent>UpCommingEvents { get; set; }
        public DbSet<Blog>Blogs { get; set; }
        public DbSet<Bio>Bios { get; set; }

        public DbSet<Event>Events { get; set; }
    }
}
