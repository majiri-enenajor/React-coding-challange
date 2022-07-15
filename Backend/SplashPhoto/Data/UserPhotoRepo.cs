using SplashPhoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashPhoto.Data
{
    public class UserPhotoRepo : IUserPhotoRepo
    {
        private readonly PhotoContext _context;
        public UserPhotoRepo(PhotoContext context)
        {
            _context = context;
        }
        public void DeletePhoto(string id)
        {
            var photos = _context.UserPhotos.Find(id);
            _context.UserPhotos.Remove(photos);
            _context.SaveChanges();
        }

        public UserPhoto GetPhotoById(string id)
        {
           return _context.UserPhotos.FirstOrDefault(photo => photo.id == id);
        }

        public List<UserPhoto> GetPhotos()
        {
           return _context.UserPhotos.ToList();
        }

        public void PostBulkPhoto(List<UserPhoto> photos)
        {
            _context.UserPhotos.AddRange(photos);
            _context.SaveChanges();

        }

        public void PostPhoto(UserPhoto photo)
        {
            _context.UserPhotos.Add(photo);
        }

        public void UpdatePhoto(string id, UserPhoto photo)
        {
            _context.UserPhotos.Update(photo);
        }
    }
}
