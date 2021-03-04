using System;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.MVVM.Model.Arguments
{
    public class RequestByteArrayFileOpenArgs : EventArgs
    {
        #region Constructors

        public RequestByteArrayFileOpenArgs(CVariable var)
        {
            Variable = var;
        }

        #endregion Constructors

        #region Properties

        public CVariable Variable { get; }

        #endregion Properties
    }

    public class RequestEmbeddedFileOpenArgs : EventArgs
    {
        #region Constructors

        public RequestEmbeddedFileOpenArgs(CR2WEmbeddedWrapper embeddedfile)
        {
            Embeddedfile = embeddedfile;
        }

        #endregion Constructors

        #region Properties

        public CR2WEmbeddedWrapper Embeddedfile { get; }

        #endregion Properties
    }
}
