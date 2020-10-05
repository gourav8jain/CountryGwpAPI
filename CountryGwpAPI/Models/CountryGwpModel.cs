using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryGwpAPI.Constants;
using CsvHelper.Configuration.Attributes;

namespace CountryGwpAPI.Models
{
    public class CountryGwpModel
    {
        [Name(CsvHeaders.Country)]
        public string Country { get; set; }
        [Name(CsvHeaders.VariableId)]

        public string VariableId { get; set; }

        [Name(CsvHeaders.VariableName)]
        public string VariableName { get; set; }

        [Name(CsvHeaders.LineOfBusiness)]
        public string LineOfBusiness { get; set; }

        [Name(CsvHeaders.Y2000)]
        public string Y2000 { get; set; }

        [Name(CsvHeaders.Y2001)]
        public string Y2001 { get; set; }

        [Name(CsvHeaders.Y2002)]
        public string Y2002 { get; set; }

        [Name(CsvHeaders.Y2003)]
        public string Y2003 { get; set; }

        [Name(CsvHeaders.Y2004)]
        public string Y2004 { get; set; }

        [Name(CsvHeaders.Y2005)]
        public string Y2005 { get; set; }

        [Name(CsvHeaders.Y2006)]
        public string Y2006 { get; set; }

        [Name(CsvHeaders.Y2007)]
        public string Y2007 { get; set; }

        [Name(CsvHeaders.Y2008)]
        public string Y2008 { get; set; }

        [Name(CsvHeaders.Y2009)]
        public string Y2009 { get; set; }

        [Name(CsvHeaders.Y2010)]
        public string Y2010 { get; set; }

        [Name(CsvHeaders.Y2011)]
        public string Y2011 { get; set; }

        [Name(CsvHeaders.Y2012)]
        public string Y2012 { get; set; }

        [Name(CsvHeaders.Y2013)]
        public string Y2013 { get; set; }

        [Name(CsvHeaders.Y2014)]
        public string Y2014 { get; set; }

        [Name(CsvHeaders.Y2015)]
        public string Y2015 { get; set; }
    }
}
