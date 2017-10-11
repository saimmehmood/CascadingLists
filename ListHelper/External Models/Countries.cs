using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ListHelper.External_Models
{
    /// <summary>  
    /// This class is being serialized to XML.  
    /// </summary>  
    [Serializable]
    [XmlRoot("Countries"), XmlType("Countries")]
    public class Countries
    {
        public string countryName { get; set; }
        public string capital { get; set; }
    }
}
