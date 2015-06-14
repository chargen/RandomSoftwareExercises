using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Tree
{
    public class Country
    {
        private string capital { get; set; }
        private string name { get; set; }

        public Country(string pCapital, string pCountry)
        {
            capital = pCapital;
            name = pCountry;
        }

        public string GetCapital()
        {
            return capital;
        }

        public string GetCountry()
        {
            return name;
        }

        public override string ToString()
        {
            string contents = string.Empty;

            contents = "Capital: " + capital + ", Country: " + name;

            return contents;
        }
    }
}
