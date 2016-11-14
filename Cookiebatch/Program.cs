using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookiebatch.Batch;

namespace Cookiebatch
{
    class Program
    {
        static void Main(string[] args)
        {
            batch Cookiebatch = new batch();

            Cookiebatch.createcookies(true, true, "round", "oatmeal");
            Cookiebatch.createcookies(true, true, "round", "sugar");
            Cookiebatch.createcookies(true, true, "round", "gingerbread");
            Cookiebatch.createcookies(true, true, "round", "chocolate chip");
            Cookiebatch.createcookies(true, false, "round", "oatmeal");
            Cookiebatch.createcookies(true, false, "round", "sugar");
            Cookiebatch.createcookies(false, true, "round", "gingerbread");
            Cookiebatch.createcookies(true, true, "round", "chocolatechip");
            Cookiebatch.createcookies(true, true, "oval", "oatmeal");
            Cookiebatch.createcookies(false, true, "round", "oatmeal");
            Cookiebatch.createcookies(true, true, "round", "gingerbread");
            Cookiebatch.createcookies(false, false, "round", "oatmeal");

            int cookies;

            for (cookies = 1; cookies <= Cookiebatch.cookiebatch.Count; cookies++)

            {
                Console.WriteLine(Cookiebatch.cookiebatch[cookies - 1].type);

                Console.WriteLine(Cookiebatch.cookiebatch[cookies - 1].shape);

                Console.WriteLine(Cookiebatch.cookiebatch[cookies - 1].hasFilling);

                Console.WriteLine(Cookiebatch.cookiebatch[cookies - 1].hasIcing);
            }

            Console.ReadKey();




        }
    }
    }

