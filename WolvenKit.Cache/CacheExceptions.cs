using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Cache
{
    public class CacheWritingException : Exception
    {
        public CacheWritingException(string message) : base(message)
        {
        }
    }
}
