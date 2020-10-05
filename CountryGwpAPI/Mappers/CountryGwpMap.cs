using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryGwpAPI.Models;
using CsvHelper.Configuration;

namespace CountryGwpAPI.Mappers
{
    public sealed class CountryGwpMap : ClassMap<CountryGwpModel>
    {
        public CountryGwpMap()
        {
            Map(m => m.Country).Name(Constants.CsvHeaders.Country);
            Map(m => m.LineOfBusiness).Name(Constants.CsvHeaders.LineOfBusiness);
            Map(m => m.VariableId).Name(Constants.CsvHeaders.VariableId);
            Map(m => m.VariableName).Name(Constants.CsvHeaders.VariableName);
            Map(m => m.Y2000).Name(Constants.CsvHeaders.Y2000);
            Map(m => m.Y2001).Name(Constants.CsvHeaders.Y2001);
            Map(m => m.Y2002).Name(Constants.CsvHeaders.Y2002);
            Map(m => m.Y2003).Name(Constants.CsvHeaders.Y2003);
            Map(m => m.Y2004).Name(Constants.CsvHeaders.Y2004);
            Map(m => m.Y2005).Name(Constants.CsvHeaders.Y2005);
            Map(m => m.Y2006).Name(Constants.CsvHeaders.Y2006);
            Map(m => m.Y2007).Name(Constants.CsvHeaders.Y2007);
            Map(m => m.Y2008).Name(Constants.CsvHeaders.Y2008);
            Map(m => m.Y2009).Name(Constants.CsvHeaders.Y2009);
            Map(m => m.Y2010).Name(Constants.CsvHeaders.Y2010);
            Map(m => m.Y2011).Name(Constants.CsvHeaders.Y2011);
            Map(m => m.Y2012).Name(Constants.CsvHeaders.Y2012);
            Map(m => m.Y2013).Name(Constants.CsvHeaders.Y2013);
            Map(m => m.Y2014).Name(Constants.CsvHeaders.Y2014);
            Map(m => m.Y2015).Name(Constants.CsvHeaders.Y2015);
        }
    }
}
