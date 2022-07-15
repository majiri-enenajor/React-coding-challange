using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashPhoto.Models
{
    public class UserPhoto
    {
        public string id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string color { get; set; }
        public string blur_hash { get; set; }
        public int likes { get; set; }
        public bool liked_by_user { get; set; }
        public string description { get; set; }
        public User user { get; set; }
        public List<CurrentUserCollection> current_user_collections { get; set; }
        public Urls urls { get; set; }
        public Links links { get; set; }
    }
}
