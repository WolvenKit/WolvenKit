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

    [Verb("cr2w", HelpText = "CyberPunk 77 cr2w Tools.")]
    public class Cr2wOptions
    {
        [Option(HelpText = "Specify the cr2w path.", Required = true)]
        public string path { get; set; }

        [Option(HelpText = "Dump info.", Required = false)]
        public bool dump { get; set; }
    }
}
