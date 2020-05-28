using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace RestToXml
{
    public class RestCountryService : ICountryService
    {
        private static readonly string Address = ConfigurationManager.AppSettings["rest_url"];
        public List<Country> GeCountries(string term)
        {

            var client = new WebClient
            {
                BaseAddress = Address
            };
            var response = client.DownloadString(term);
            var list = JsonConvert.DeserializeObject<List<Country>>(response);
            return list;
        }
    }
}