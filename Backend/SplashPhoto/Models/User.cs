using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashPhoto.Models
{
    public class User
    {
        public string id { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string portfolio_url { get; set; }
        public string bio { get; set; }
        public string location { get; set; }
        public int total_likes { get; set; }
        public int total_photos { get; set; }
        public int total_collections { get; set; }
        public string instagram_username { get; set; }
        public string twitter_username { get; set; }
        public ProfileImage profile_image { get; set; }
        public Links links { get; set; }
    }
}
