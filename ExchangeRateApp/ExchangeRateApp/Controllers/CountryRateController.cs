using ExchangeRateApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ExchangeRateApp.Controllers
{
    public class CountryRateController : ApiController
    {
        public IEnumerable<CountryRate> Get()
        {
            return CountryRate.GetAll();
        }

        [HttpGet]
        [ActionName("ExchangeCurrency")]
        public CountryRateResult ExchangeCurrency(string source, string target, string amount)
        {
            CountryRateResult result = new CountryRateResult();
            result.SourceCountryName = source;
            result.TargetCountryName = target;

            decimal dAmount = 0;
            decimal.TryParse(amount, out dAmount);

            var allCountryRates = CountryRate.GetAll();

            CountryRate sourceCountry = allCountryRates.FirstOrDefault(x => x.CountryName.ToLower() == source.ToLower());
            CountryRate targetCountry = allCountryRates.FirstOrDefault(x => x.CountryName.ToLower() == target.ToLower());

            if (sourceCountry == null || targetCountry == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            result.SourceCountryCurrency = sourceCountry.CountryCurrency;
            result.SourceExchangeRate = sourceCountry.ExchangeRate;
            result.TargetCountryCurrency = targetCountry.CountryCurrency;
            result.TargetExchangeRate = targetCountry.ExchangeRate;

            decimal total = dAmount * targetCountry.ExchangeRate / sourceCountry.ExchangeRate;

            result.ConversionAmount = Math.Round(total, 2);

            return result;
        }
    }
}
