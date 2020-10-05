using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CountryGwpAPI.Exception_Handling;
using CountryGwpAPI.Mappers;
using CountryGwpAPI.Models;
using CountryGwpAPI.Services.Interfaces;
using CsvHelper;
using Microsoft.Extensions.Configuration;

namespace CountryGwpAPI.Services.Implementation
{
    public class CsvParserService : ICsvParserService
    {
        public async Task<List<CountryGwpModel>> ReadCsvFileAndLoadIntoCountryGwpModel()
        {

            var task = Task.Run(() =>
            {
                var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                    "gwpByCountry.csv");
                using (TextReader reader = new StreamReader(path))
                {
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        csv.Configuration.RegisterClassMap<CountryGwpMap>();
                        var records = csv.GetRecords<CountryGwpModel>().ToList();
                        return records;
                    }
                }
            });

            return await task;
        }
    }
}
