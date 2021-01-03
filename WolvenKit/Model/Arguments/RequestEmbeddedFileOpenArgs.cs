using System;
using System.IO;
using WolvenKit.Common.Model;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Model
{
    public class RequestEmbeddedFileOpenArgs : EventArgs
    {
        public CR2WEmbeddedWrapper Embeddedfile { get; }

        public RequestEmbeddedFileOpenArgs(CR2WEmbeddedWrapper embeddedfile)
        {
            Embeddedfile = embeddedfile;
        }
    }

    public class RequestByteArrayFileOpenArgs : EventArgs
    {
        public CVariable Variable { get; }

        public RequestByteArrayFileOpenArgs(CVariable var)
        {
            Variable = var;
        }
    }
}