using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InroToOOP
{
    partial class Freezer
    {
        static Freezer()
        {
            count = 0;
            count1 = "0";
        }
        public Freezer() : this("no color", 0, "no type", "no brend", 0) { }
        public Freezer(string c)
        {
            Color = c;
            Price = 0;
            Type = "no type";
            Brend = "No brend";
            Area = 0;
        }
        public Freezer(string c, int pr)
        {
            Color = c;
            Price = pr;
            Type = "no type";
            Brend = "No brend";
            Area = 0;
        }
        public Freezer(string c, int pr, string t)
        {
            Color = c;
            Price = pr;
            Type = t;
            Brend = "No brend";
            Area = 0;
        }
        public Freezer(string c, int pr, string t, string br)
        {
            Color = c;
            Price = pr;
            Type = t;
            Brend = br;
            Area = 0;
        }
        public Freezer(string c, int pr, string t, string br, int ar)
        {
            Color = c;
            Price = pr;
            Type = t;
            Brend = br;
            Area = ar;
        }
        public void Print()
        {
            Console.WriteLine($"Color - {Color}, Price - {Price}, Type - {Type}, Brend - {Brend}, Area - {Area}.");
        }
        public override string ToString()
        {
            return $"Color - {Color}, Price - {Price}, Type - {Type}, Brend - {Brend}, Area - {Area}.";
        }
    }
}
