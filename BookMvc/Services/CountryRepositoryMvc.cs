using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookMvc.Services
{
    public class CountryRepositoryMvc : ICountryRepositoryMvc
    {
        public CountryDto GetAuthorsFromACountry(int authorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AuthorDto> GetAuthorsFromCounty()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CountryDto> GetCountries()
        {
            IEnumerable<CountryDto> countries = new List<CountryDto>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60039/api/");

                var response = client.GetAsync("countries");
                response.Wait();

                var result = response.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<CountryDto>>();
                    readTask.Wait();

                    countries = readTask.Result;
                }
            }
            return countries;
        }

        public CountryDto GetCountryByID(int countryId)
        {
            CountryDto country = new CountryDto();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60039/api/");

                var response = client.GetAsync($"countries/{countryId}");
                response.Wait();

                var result = response.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<CountryDto>();
                    readTask.Wait();

                    country = readTask.Result;
                }
            }
            return country;
        }
    }
}
