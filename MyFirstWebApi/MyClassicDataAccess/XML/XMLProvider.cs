using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassicDataAccess.Operations;

namespace MyClassicDataAccess.XML
{
    public class XMLProvider : DBProvider
    {
        public override IBulkUpdate CreateBulkUpdateProvider()
        {
            throw new NotImplementedException();
        }

        public override IFunction CreateExecFunctionProvider()
        {
            throw new NotImplementedException();
        }

        public override IStoredProcedure CreateExecSPProvider()
        {
            throw new NotImplementedException();
        }

        public override IQuery CreateQueryProvider()
        {
            return new XMLQuery();
        }
    }
}
