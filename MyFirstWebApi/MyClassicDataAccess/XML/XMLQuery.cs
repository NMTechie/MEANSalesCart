using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MyClassicDataAccess.Operations;


namespace MyClassicDataAccess.XML
{
    public class XMLQuery : IQuery
    {
        /// <summary>
        /// This will provide generic method to get data from XML data source
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Xpathquery">It expects query to be in Xpath expression</param>
        /// <returns></returns>
        public IEnumerable<T> GetDataFromSelection<T>(string Xpathquery)
        {            
            var xmlToLoad = @"D:\152089-Nilesh\Projects\POCs\MEANExp\MEANSalesCart\MyFirstWebApi\MyClassicDataStore\UserData.xml"; 
            /*Below line depicts the user of as operator for type conversion wherse explicit cast (type)object 
            is not preffered because of invalid cast operation than to null return*/        
            return XDocument.Load(xmlToLoad).XPathSelectElements(Xpathquery) as IEnumerable<T>;            
        }
    }
}
