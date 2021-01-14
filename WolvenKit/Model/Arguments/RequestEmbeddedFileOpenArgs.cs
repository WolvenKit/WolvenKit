using System;
using System.IO;

namespace WolvenKit.Model
{
    using Common.Model;
    using CR2W;
    using CR2W.Types;

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