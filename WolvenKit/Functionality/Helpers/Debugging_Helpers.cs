using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Functionality.Helpers
{
    public static partial class Helpers
    {
        /// <summary>
        /// Static Bool : If Debugging is enabled.
        /// </summary>
        public static bool c_IsDebugEnabled { get; set; } = false;


        /// <summary>
        /// Enable Debugging (Shows all UI options even if not functional.
        /// </summary>
        public static void DBG_Enable() => Helpers.c_IsDebugEnabled = true;



    }




}
