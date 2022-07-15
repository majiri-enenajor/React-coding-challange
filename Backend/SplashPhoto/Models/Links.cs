using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashPhoto.Models
{
    public class Links
    {
        public int id { get; set; }
        public string self { get; set; }
        public string html { get; set; }
        public string photos { get; set; }
        public string likes { get; set; }
        public string portfolio { get; set; }
        public string download { get; set; }
        public string download_location { get; set; }
    }
}
