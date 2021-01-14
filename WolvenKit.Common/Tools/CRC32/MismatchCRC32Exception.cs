using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RED.CRC32
{
    public class MismatchCRC32Exception : Exception
    {
        public MismatchCRC32Exception()
        {

        }

        public MismatchCRC32Exception(string message) : base(message)
        {

        }

        public MismatchCRC32Exception(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
