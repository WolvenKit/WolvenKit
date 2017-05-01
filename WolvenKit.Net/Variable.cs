using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Net
{
    //These are returned when we recieve from the game 0xFFFFFFFFCC00CC00 aka Varlist
    public class Variable
    {
        public string byte1;
        public string byte2;
        public string Section { get; set; }
        public string Varname { get; set; }
        public string Value { get; set; }
    }
}
