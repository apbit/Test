using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCodeApp.Models
{
    public class Country
    {
        public int CountryCode
        {
            get;
            set;
        }
        public string CountryName
        {
            get;
            set;
        }
        public string CurrencyName
        {
            get;
            set;
        }

        public static List<Country> GetAll()
        {
            List<Country> allCountries = new List<Country>();

            allCountries.Add(new Country
            {
                CountryCode = 1,
                CountryName = "USA",
                CurrencyName = "Dollar"
            });
            allCountries.Add(new Country
            {
                CountryCode = 52,
                CountryName = "Mexico",
                CurrencyName = "Peso"
            });
            allCountries.Add(new Country
            {
                CountryCode = 39,
                CountryName = "Italy",
                CurrencyName = "Euro"
            });
            allCountries.Add(new Country
            {
                CountryCode = 44,
                CountryName = "Great Britain",
                CurrencyName = "Pound"
            });

            return allCountries;
        }
    }
}