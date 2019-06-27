using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertixWS.Data
{
    public class CertixWSAdapter : CertixWSAdapterBase
    {
        public CertixWSAdapter(System.Data.IDbConnection connection, IDbTransaction transaction) :
            base(connection, transaction)
        { }

      


    }
}
