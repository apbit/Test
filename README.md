Test
====

CountryCodepp.

This application has the following values hardcoded:
            
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
            
When consuming this Web API service, use a phone number of 10 digits that is prefixed with any of the codes from 
the allCountries list.

To consume this service, the following route was added: 

              config.Routes.MapHttpRoute(
                name: "CountryPhone",
                routeTemplate: "api/{controller}/{action}/{phonenumber}"
            );
  

Exchange Rate App

To consume this Web API service, the following route was added:

            config.Routes.MapHttpRoute(
               name: "ExchangeCurrency",
               routeTemplate: "api/{controller}/{action}/{source}/{target}/{amount}"              
           );
           
The source and target countries are hardcoded to accept the following values: "USA", "Mexico", "Great Britain", "Canada", "EU" 
and "China".

The amount could be any decimal amount. A new model, called "CountryRateResult" is returned by the service.
