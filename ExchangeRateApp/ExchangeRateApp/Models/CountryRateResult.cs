using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExchangeRateApp.Models
{
    public class CountryRateResult
    {
        public string SourceCountryName
        {
            get;
            set;
        }

        public string SourceCountryCurrency
        {
            get;
            set;
        }

        public decimal SourceExchangeRate
        {
            get;
            set;
        }

        public string TargetCountryName
        {
            get;
            set;
        }

        public string TargetCountryCurrency
        {
            get;
            set;
        }

        public decimal TargetExchangeRate
        {
            get;
            set;
        }

        public decimal ConversionAmount
        {
            get;
            set;
        }
    }
}