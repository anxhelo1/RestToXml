using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestToXml
{
    public class Country
    {
        public string name { get; set; }
        public string alpha3Code { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public string capital { get; set; }
    }
}