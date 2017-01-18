using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.Mod
{
    public class ModManager
    {
        private static ModManager instance;

        public static ModManager Get()
        {
            if (instance == null)
            {
                instance = new ModManager();
            }

            return instance;
        }

        public W3Mod ActiveMod { get; set; }
    }
}
