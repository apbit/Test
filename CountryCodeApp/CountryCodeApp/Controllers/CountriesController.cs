using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CountryCodeApp.Models;

namespace CountryCodeApp.Controllers
{
    public class CountriesController : ApiController
    {
        public IEnumerable<Country> Get()
        {
            return Country.GetAll();
        }

        [HttpGet]
        [ActionName("GetByPhoneNumber")]
        public Country GetByPhoneNumber(string phoneNumber)
        {
            //remove the 10 digits of the phone number to extract the country code.
            string code = phoneNumber.Substring(0, phoneNumber.Length - 10);

            int countryCode = 0;
            int.TryParse(code, out countryCode);

            Country countryForCode = Country.GetAll().FirstOrDefault(x => x.CountryCode == countryCode);

            if (countryForCode == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return countryForCode;
        }
    }
}