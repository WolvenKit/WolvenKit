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

    [Verb("dumpXBM", HelpText = "Dumps xbm info from bundles.")]
    class DumpXbmsOptions
    {

    }

    [Verb("dumpeffects", HelpText = "Dumps cookedEffect names info from bundles.")]
    class DumpCookedEffectsOptions
    {
        [Option(HelpText = "Specify the game path.", Required = true)]
        public string path { get; set; }
    }

    [Verb("dumpDDS", HelpText = "Dumps dds info from texture caches.")]
    class DumpDDSOptions
    {

    }

    [Verb("dumpCOL", HelpText = "Dumps collision cache info from collision caches.")]
    class DumpCollisionOptions
    {
        [Option(HelpText = "Specify the game path.", Required = true)]
        public string path { get; set; }
    }

    [Verb("dumpFileNames1", HelpText = "Dumps all file names found in the archives.")]
    class DumpArchivedFileInfosOptions
    {

    }

    [Verb("dumpMetadataStore", HelpText = "Dumps the content of metadata.store.")]
    class DumpMetadataStoreOptions
    {

    }

    [Verb("cr", HelpText = "Load cr2w content in postgres")]
    class CR2WToPostgresOptions
    {

    }
}
