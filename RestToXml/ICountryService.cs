using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestToXml
{
    public interface ICountryService
    {
        List<Country> GeCountries(string term);
    }
}
