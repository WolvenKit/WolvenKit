using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Console
{
    
    [Verb("cache", HelpText = "Witcher 3 Cache IO.")]
    class CacheOptions
    {
        [Option(HelpText = "Specify the cache path.", Required = true)]
        public string path { get; set; }
    }
    [Verb("bundle", HelpText = "Witcher 3 Bundle IO.")]
    class BundleOptions
    {
        [Option(HelpText = "Specify the bundle path.", Required = true)]
        public string path { get; set; }
    }
}
