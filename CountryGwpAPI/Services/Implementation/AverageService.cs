using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryGwpAPI.ApiModels;
using CountryGwpAPI.Services.Interfaces;

namespace CountryGwpAPI.Services.Implementation
{
    public class AverageService : IAverageService
    {
        private readonly ICsvParserService _csvParserService;

        public AverageService(ICsvParserService csvParserService)
        {
            _csvParserService = csvParserService;
        }


        public async Task<object> GetAverage(CountryGwpApiModel countryGwpApiModel)
        {
            var csvModel = await _csvParserService.ReadCsvFileAndLoadIntoCountryGwpModel();
            var result = csvModel.Where(x =>
                    x.Country.Equals(countryGwpApiModel.Country, StringComparison.InvariantCultureIgnoreCase) && countryGwpApiModel.LineOfBusiness.Contains(x.LineOfBusiness))
                .GroupBy(x => x.LineOfBusiness)
                .ToDictionary(x => x.Key, x => x.Select(y =>
                    ((!string.IsNullOrWhiteSpace(y.Y2008) ? Convert.ToDecimal(y.Y2008) : 0) +
                     (!string.IsNullOrWhiteSpace(y.Y2009) ? Convert.ToDecimal(y.Y2009) : 0) +
                     (!string.IsNullOrWhiteSpace(y.Y2010) ? Convert.ToDecimal(y.Y2010) : 0) +
                     (!string.IsNullOrWhiteSpace(y.Y2011) ? Convert.ToDecimal(y.Y2011) : 0) +
                     (!string.IsNullOrWhiteSpace(y.Y2012) ? Convert.ToDecimal(y.Y2012) : 0) +
                     (!string.IsNullOrWhiteSpace(y.Y2013) ? Convert.ToDecimal(y.Y2013) : 0) +
                     (!string.IsNullOrWhiteSpace(y.Y2014) ? Convert.ToDecimal(y.Y2014) : 0) +
                     (!string.IsNullOrWhiteSpace(y.Y2015) ? Convert.ToDecimal(y.Y2015) : 0)) / 8));

            return result;

        }
    }
}
