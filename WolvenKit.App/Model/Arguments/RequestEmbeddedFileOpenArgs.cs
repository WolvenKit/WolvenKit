using System;
using System.IO;
using WolvenKit.Common.Model;
using WolvenKit.CR2W;

namespace WolvenKit.App.Model
{
    public class RequestEmbeddedFileOpenArgs : EventArgs
    {
        public CR2WEmbeddedWrapper Embeddedfile { get; }

        public RequestEmbeddedFileOpenArgs(CR2WEmbeddedWrapper embeddedfile)
        {
            Embeddedfile = embeddedfile;
        }
    }
}