using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Conversion
{
    public class RedFileDto
    {
        internal List<int> _handles = new();

        public const string Magic = "w2rc";

        public string WolvenKitVersion = "8.5.0";
        public string WKitJsonVersion = "0.0.1";
        public string ExportedDateTime => DateTime.UtcNow.ToString("o");
        public string ArchiveFileName;

        [JsonProperty(Order = 1)]
        public RedClassDto Root;


        public RedFileDto()
        {

        }

        public RedFileDto(CR2WFile cr2w)
        {
            Root = new RedClassDto(cr2w.RootChunk, this);
            ArchiveFileName = cr2w.MetaData.FileName;
            // not sure if we should be referencing the project here
            var archiveLocation = "source\\archive\\";
            if (ArchiveFileName != null && ArchiveFileName.IndexOf(archiveLocation) is var index && index != -1)
            {
                ArchiveFileName = ArchiveFileName.Substring(index + archiveLocation.Length);
            }
            // never assigned i guess :/
            //WolvenKitVersion = cr2w.MetaData.BuildVersion.ToString();
        }

        public bool RegisterHandle(int handleHash)
        {
            if (_handles.Contains(handleHash))
            {
                return false;
            }
            else
            {
                _handles.Add(handleHash);
                return true;
            }
        }

        public CR2WFile ToW2rc()
        {
            var cr2w = new CR2WFile()
            {
                RootChunk = Root.ToRedBaseClass()
            };

            return cr2w;
        }
    }
}
