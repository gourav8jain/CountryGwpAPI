using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryGwpAPI.ApiModels;
using CountryGwpAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CountryGwpAPI.Controllers
{
    [Route("server/api")]
    [ApiController]
    public class CountryGwpController : ControllerBase
    {
        private readonly IAverageService _averageService;

        public CountryGwpController(IAverageService averageService)
        {
            _averageService = averageService;
        }
        
        // GET: api/<CountryGwpController>
        [HttpPost("gwp/avg")]
        public async Task<object> GetAverage([FromBody] CountryGwpApiModel countryGwpApiModel)
        {
            var result =  await _averageService.GetAverage(countryGwpApiModel);
            return result;
        }
    }
}
