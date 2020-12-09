using System;
using System.Collections.Generic;
using System.Text;
using CommandLine;

namespace CP77Tools
{
    [Verb("archive", HelpText = "CyberPunk 77 Archive Tools.")]
    public class ArchiveOptions
    {
        [Option(HelpText = "Specify the archive path.", Required = true)]
        public string path { get; set; }

        [Option(HelpText = "Dump info.", Required = false)]
        public bool dump { get; set; }

        [Option(HelpText = "Extract files.", Required = false)]
        public bool extract { get; set; }

        [Option(HelpText = "Output files extension", Required = false)]
        public string extension { get; set; }
    }

    [Verb("dump", HelpText = "CyberPunk 77 Tools.")]
    public class DumpOptions
    {
        [Option(HelpText = "Specify the cr2w path.", Required = true)]
        public string path { get; set; }

        [Option(HelpText = "Dump strings.", Required = false)]
        public bool strings { get; set; }

        [Option(HelpText = "Dump imports.", Required = false)]
        public bool imports { get; set; }

        [Option(HelpText = "Dump buffers.", Required = false)]
        public bool buffers { get; set; }
    }


    [Verb("cr2w", HelpText = "CyberPunk 77 cr2w Tools.")]
    public class CR2WOptions
    {
        [Option(HelpText = "Specify the cr2w path.", Required = true)]
        public string path { get; set; }
    }
}
