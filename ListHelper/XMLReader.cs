using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Data;
using System.Xml;
using ListHelper.External_Models;

namespace ListHelper
{
    public class XMLReader
    {
        /// <summary>  
        /// Return list of countries from XML.  
        /// </summary>  
        /// <returns>List of countries</returns>  
        public List<Countries> ListOfCountries()
        {
            XmlDocument doc = new XmlDocument();
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data/CountryData.xml");//Path of the xml file.
            doc.Load(xmlData);

            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/countries/country");


            var countries = new List<Countries>();

            countries = (from XmlNode node in nodes
                         select new Countries
                         {
                            countryName = node.Attributes["countryName"].Value.ToString(),
                            capital = node.Attributes["capital"].Value.ToString(),
                         }).ToList();
            
            // Returning List of Countries
            return countries;
        }
    }
}
