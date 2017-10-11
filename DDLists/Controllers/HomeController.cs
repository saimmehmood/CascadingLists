using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Xml;
using ListHelper;
using ListHelper.External_Models;
using System.Globalization;


namespace DDLists.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<string> CountryList = new List<string>(); 
            List<string> CapitalName = new List<string>();

            XMLReader readXML = new XMLReader(); // Creating Xml Reader object
            var data = readXML.ListOfCountries(); // Getting list of countries from Xml Reader class

            // Separating country name and its capital and storing them inside separate lists.
            foreach (var item in data)
            {
                CountryList.Add(item.countryName);
                CapitalName.Add(item.capital);
            }

            // Using ViewBag to pass data into Home View (Index.cshtml)
            ViewBag.CountryList = CountryList; 
            ViewBag.CapitalName = CapitalName;
            return View();
        }
    }

    
}