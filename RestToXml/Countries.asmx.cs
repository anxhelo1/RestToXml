using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;

namespace RestToXml
{
    /// <summary>
    /// Summary description for Countries
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Countries : System.Web.Services.WebService
    {
        protected ICountryService service { get; set; }

        [WebMethod]
        public List<Country> GetCountries(string searchTerm)
        {
            service = new RestCountryService();
            return service.GeCountries(searchTerm);
        }
    }
}
