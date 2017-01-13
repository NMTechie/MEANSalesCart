using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassicDataAccess.Operations
{
    public interface IQuery
    {
        /// <summary>
        /// This will provide generic method to get data from data source
        /// </summary>
        /// <typeparam name="T">The expected type from provider</typeparam>
        /// <param name="query">Query that will fetch the data</param>
        /// <returns></returns>
        IEnumerable<T> GetDataFromSelection<T>(string query);
    }
}
