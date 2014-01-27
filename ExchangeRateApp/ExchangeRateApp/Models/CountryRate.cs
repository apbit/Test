using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExchangeRateApp.Models
{
    public class CountryRate
    {
        public string CountryName
        {
            get;
            set;
        }

        public string CountryCurrency
        {
            get;
            set;
        }

        public decimal ExchangeRate
        {
            get;
            set;
        }

        internal static IEnumerable<CountryRate> GetAll()
        {
            List<CountryRate> allCountryRates = new List<CountryRate>();

            allCountryRates.Add(new CountryRate
            {
                CountryName = "USA",
                CountryCurrency = "Dollar",
                ExchangeRate = 1.0M
            });

            allCountryRates.Add(new CountryRate
            {
                CountryName = "EU",
                CountryCurrency = "Euro",
                ExchangeRate = 0.74M
            });

            allCountryRates.Add(new CountryRate
            {
                CountryName = "Mexico",
                CountryCurrency = "Peso",
                ExchangeRate = 13.27M
            });

            allCountryRates.Add(new CountryRate
            {
                CountryName = "Great Britain",
                CountryCurrency = "Pound Sterling",
                ExchangeRate = 0.61M
            });

            allCountryRates.Add(new CountryRate
            {
                CountryName = "Canada",
                CountryCurrency = "Canadian Dollar",
                ExchangeRate = 1.10M
            });

            allCountryRates.Add(new CountryRate
            {
                CountryName = "China",
                CountryCurrency = "Yuan",
                ExchangeRate = 6.05M
            });

            return allCountryRates;
        }
    }
}