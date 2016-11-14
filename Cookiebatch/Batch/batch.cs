using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookiebatch.cookies;

namespace Cookiebatch.Batch
{
    class batch
    {
        public string shape { get; set; }

        public string size { get; set; }

        public string color { get; set; }

        public string capacity { get; set; }

        public List<Cookies> cookiebatch { get {
                return plate;
            }  }

        private List<Cookies> plate = new List<Cookies>();

        public void createcookies (bool hasIcing,bool hasFiling,string shape, string type)
        {
            Cookies anyCookie = new Cookies();
            anyCookie.hasIcing = hasIcing;
            anyCookie.hasFilling = hasFiling;
            anyCookie.shape = shape;
            anyCookie.type = type;

            plate.Add(anyCookie);


        }


        public void makeCookie(bool hasIcing,bool hasFilling, string shape, string type)
        {
            Cookies cookie = new Cookies();
            cookie.shape = shape;
            cookie.type = type;
            cookie.hasFilling = hasFilling;
            cookie.hasIcing = hasIcing;


        }


    }
}
