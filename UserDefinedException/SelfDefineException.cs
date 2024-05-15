using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    public class SelfDefineException:Exception

    {
        public SelfDefineException(string message,Exception innerException):base(message, innerException) 
        {
            
        }
    }
}
