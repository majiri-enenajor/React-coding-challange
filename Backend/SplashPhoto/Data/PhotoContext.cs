using Microsoft.EntityFrameworkCore;
using SplashPhoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashPhoto.Data
{
    public class PhotoContext: DbContext
    {
        public PhotoContext(DbContextOptions<PhotoContext> opt): base(opt)
        {

        }
        public DbSet<UserPhoto> UserPhotos { get; set; }
        public DbSet<CurrentUserCollection> CurrentUserCollections { get; set; }
        public DbSet<Links> Links { get; set; }
        public DbSet<Urls> Urls { get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<ProfileImage> ProfileImages { get; set; }

    }
}
