using CountryCodeApp.Controllers;
using CountryCodeApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace CountryCodeApp.Tests.Controllers
{
    [TestClass]
    class CountriesControllerTest
    {
        [TestMethod]
        public void GetByPhoneNumber_WrongPhoneNumber()
        {
            CountriesController controller = new CountriesController();

            Country invalidCountry = controller.GetByPhoneNumber("0000");

            Assert.IsInstanceOfType(invalidCountry, typeof(NotFoundResult));
        }

        [TestMethod]
        public void GetByPhoneNumber_FindMexico()
        {
            CountriesController controller = new CountriesController();

            Country result = controller.GetByPhoneNumber("526865555555");

            Assert.IsNotNull(result);
            Assert.AreEqual(Country.GetAll()[1].CountryName, result.CountryName);
        }
    }
}
