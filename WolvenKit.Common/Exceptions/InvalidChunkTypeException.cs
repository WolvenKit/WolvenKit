using System;

namespace WolvenKit.Common.Exceptions
{
    public class InvalidChunkTypeException : Exception
    {
        #region Constructors

        public InvalidChunkTypeException(string message)
            : base(message)
        {
        }

        #endregion Constructors
    }

    public class ModkitExportException : Exception
    {
        #region Constructors

        public ModkitExportException(string message)
            : base(message)
        {
        }

        #endregion Constructors
    }
}
