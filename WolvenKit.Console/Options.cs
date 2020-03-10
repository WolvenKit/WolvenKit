using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Console
{
    [Verb("bulkedit", HelpText = "Bulk edit cr2w files.")]
    class BulkEditOptions
    {
        [Option(HelpText = "Specify the directory of files to edit.", Required = true)]
        public string dir { get; set; }

        [Option(HelpText = "Specify the file extension to edit.", Required = false)]
        public string ext { get; set; }

        [Option(HelpText = "Specify the chunk name.", Required = false)]
        public string chunk { get; set; }


        [Option(HelpText = "Specify the variable name.", Required = true)]
        public string var { get; set; }

        [Option(HelpText = "Specify the variable type.", Required = false)]
        public string type { get; set; }

        [Option(HelpText = "Specify the new variable value.", Required = true)]
        public string val { get; set; }


    }
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
