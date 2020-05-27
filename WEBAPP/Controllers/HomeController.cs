using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WEBAPP.CountriesService;

namespace WEBAPP.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index(string searchTerm)
        {
            ViewBag.searchTerm = searchTerm;
            if (string.IsNullOrEmpty(searchTerm))
            {
                ViewBag.hasError = false;
                return View(new Country[0]);
            }

            ViewBag.searchTerm = searchTerm;
            var service = new CountriesService.CountriesSoapClient();
            try
            {

                var countries = service.GetCountries(searchTerm);
                ViewBag.hasError = false;
                return View(countries);
            }
            catch (Exception)
            {
                ViewBag.Error = "An error occured, please try again later";
                ViewBag.hasError = true;
                return View();
            }
        }
    }
}