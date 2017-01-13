using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassicDataAccess.Operations;
using MyClassicDataAccess.XML;

namespace MyClassicDataAccess
{
    public abstract class DBProvider
    {
        public abstract IQuery CreateQueryProvider();
        public abstract IStoredProcedure CreateExecSPProvider();
        public abstract IFunction CreateExecFunctionProvider();
        public abstract IBulkUpdate CreateBulkUpdateProvider();
    }

    /// <summary>
    /// This class provides the indirect wrapper to create
    /// the concrete factories
    /// </summary>
    public class GetDBFactory
    {
        public static DBProvider CreateFactory(DBChoice choice)
        {
            switch (choice)
            {
                case DBChoice.XML:
                    return new XMLProvider();
                default:
                    return new XMLProvider();
            }
        }
    }

     public enum DBChoice
     {
        XML,
        SQL
     }
}
