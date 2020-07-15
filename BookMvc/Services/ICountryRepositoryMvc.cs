using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMvc.Services
{
    public interface ICountryRepositoryMvc
    {
        IEnumerable<CountryDto> GetCountries();
        IEnumerable<AuthorDto> GetAuthorsFromCounty();
        CountryDto GetCountryByID(int countryId);
        CountryDto GetAuthorsFromACountry(int authorId);

    }
}
