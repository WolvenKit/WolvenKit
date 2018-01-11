using System;
    
namespace WolvenKit.Mod
{		
    public class ModManager
    {		
        private static ModManager instance;		
        public W3Mod ActiveMod { get; set; }		
		
        public static ModManager Get()
        {		
            return instance ?? (instance = new ModManager());		
        }		
    }		
} 