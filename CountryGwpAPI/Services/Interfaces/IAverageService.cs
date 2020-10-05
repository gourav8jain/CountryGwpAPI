using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryGwpAPI.ApiModels;

namespace CountryGwpAPI.Services.Interfaces
{
    public interface IAverageService
    {
        Task<object> GetAverage(CountryGwpApiModel countryGwpApiModel);
    }
}
