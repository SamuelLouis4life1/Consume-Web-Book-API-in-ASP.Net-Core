using BookMvc.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMvc.Controllers
{
    public class CountriesController : Controller
    {
        ICountryRepositoryMvc _countryRepository;
        public CountriesController(ICountryRepositoryMvc countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IActionResult Index()
        {
            var countries = _countryRepository.GetCountries();

            if (countries.Count() <= 0)
            {
                ViewBag.Message = "There was a problem retrieving countries from" + "the database or no contry exists";
            }

            return View(countries);
        }

    }
}
