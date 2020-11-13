using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Console
{

    [Verb("cache", HelpText = "Witcher 3 Cache IO.")]
    public class CacheOptions
    {
        [Option(HelpText = "Specify the cache path.", Required = true)]
        public string path { get; set; }

        [Option(HelpText = "Specify wether to create a texture cache from the path specified.", Required = false)]
        public bool create { get; set; }

        [Option(HelpText = "Specify wether to create a txt dump of the cache.", Required = false)]
        public bool dump { get; set; }

        [Option(HelpText = "Specify wether to extract the dds files of the cache.", Required = false)]
        public bool extract { get; set; }
    }

    [Verb("bundle", HelpText = "Witcher 3 Bundle IO.")]
    public class BundleOptions
    {
        
    }

    [Verb("dumpXBM", HelpText = "Dumps xbm info from bundles.")]
    public class DumpXbmsOptions
    {

    }

    [Verb("dumpeffects", HelpText = "Dumps cookedEffect names info from bundles.")]
    public class DumpCookedEffectsOptions
    {
        
    }

    [Verb("dumpDDS", HelpText = "Dumps dds info from texture caches.")]
    public class DumpDDSOptions
    {

    }

    [Verb("dumpCOL", HelpText = "Dumps collision cache info from collision caches.")]
    public class DumpCollisionOptions
    {
        
    }

    [Verb("dumpFileNames1", HelpText = "Dumps all file names found in the archives.")]
    public class DumpArchivedFileInfosOptions
    {

    }

    [Verb("dumpMetadataStore", HelpText = "Dumps the content of metadata.store.")]
    public class DumpMetadataStoreOptions
    {

    }

    [Verb("cr", HelpText = "Load cr2w content in postgres")]
    public class CR2WToPostgresOptions
    {

    }
}
