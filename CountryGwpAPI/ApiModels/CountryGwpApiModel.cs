using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CountryGwpAPI.ApiModels
{
    public class CountryGwpApiModel
    {
        [Required]
        [JsonProperty(PropertyName = "Country")]
        public string Country { get; set; }

        [Required]
        [JsonProperty(PropertyName = "LineOfBusiness")]
        public List<string> LineOfBusiness { get; set; }
    }
}
