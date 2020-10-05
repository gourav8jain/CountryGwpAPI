using System.Collections.Generic;
using System.Threading.Tasks;
using CountryGwpAPI.Models;

namespace CountryGwpAPI.Services.Interfaces
{
    public interface ICsvParserService
    {
        Task<List<CountryGwpModel>> ReadCsvFileAndLoadIntoCountryGwpModel();
    }
}
