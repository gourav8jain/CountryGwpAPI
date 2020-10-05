using CountryGwpAPI.ApiModels;
using CountryGwpAPI.Controllers;
using CountryGwpAPI.Services.Interfaces;
using Moq;
using Newtonsoft.Json;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Collections.Generic;
using System.Threading.Tasks;
using CountryGwpAPI.Models;
using CountryGwpAPI.Services.Implementation;

namespace CountryGwpAPI.UnitTests
{
    [TestFixture]
    public class CountryGwpControllerTest
    {
        private CountryGwpController _countryGwpController;
        private IAverageService _averageService;
        private readonly Mock<ICsvParserService> _csvParserMock = new Mock<ICsvParserService>();

        [SetUp]
        public void SetUp()
        {

            var mockData = _csvParserMock.Setup(x => x.ReadCsvFileAndLoadIntoCountryGwpModel()).Returns(() =>
                {
                    var task =  new List<CountryGwpModel>
                    {

                        new CountryGwpModel
                        {
                            Country = "ae",
                            LineOfBusiness = "transport",
                            VariableId = "gwp",
                            VariableName = "Direct Premiums",
                            Y2008 = "268744928.7",
                            Y2009 = "284448918.2",
                            Y2010 = "314413884.1",
                            Y2011 = "327740154.4",
                            Y2012 = "326126300.6",
                            Y2013 = "240322742.6",
                            Y2014 = "234164748.7"
                        }
                    };

                    return Task.FromResult(task);
                }
            );


        }

        [Test]
        public void GetAverageReturnResults()
        {

            var expectedReponse =
                "{\"transport\":[249495209.6625]}";

            _averageService = new AverageService(_csvParserMock.Object);
            _countryGwpController = new CountryGwpController(_averageService);

            var input = new CountryGwpApiModel
            {
                Country = "ae",
                LineOfBusiness = new List<string> { "transport"}
            };

            var actualResponse = _countryGwpController.GetAverage(input).Result;
            Assert.AreEqual(JsonConvert.SerializeObject(actualResponse), expectedReponse);
        }
    }
}