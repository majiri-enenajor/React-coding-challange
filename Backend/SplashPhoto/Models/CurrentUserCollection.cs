using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashPhoto.Models
{
    public class CurrentUserCollection
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime published_at { get; set; }
        public DateTime last_collected_at { get; set; }
        public DateTime updated_at { get; set; }
        public string cover_photo { get; set; }
        public string user { get; set; }
    }
}
