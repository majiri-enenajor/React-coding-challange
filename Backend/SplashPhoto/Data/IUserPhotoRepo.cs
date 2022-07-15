using SplashPhoto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashPhoto.Data
{
    public interface IUserPhotoRepo
    {
        List<UserPhoto> GetPhotos();
        UserPhoto GetPhotoById(string id);
        void DeletePhoto(string id);
        void UpdatePhoto(string id, UserPhoto photo);
        void PostBulkPhoto(List<UserPhoto> photos);
        void PostPhoto(UserPhoto photo);
    }
}
