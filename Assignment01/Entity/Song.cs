using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store.Preview.InstallControl;

namespace Assignment01.Entity
{
    public class Song
    {
        public String name { get; set; }
        public String description { get; set; }
        public String singer { get; set; }
        public String author { get; set; }
        public String thumbnail { get; set; }
        public String link { get; set; }
    }
}
