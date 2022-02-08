using System;

namespace WolvenKit.Common.Exceptions
{
    public class InvalidChunkTypeException : Exception
    {
        public InvalidChunkTypeException(string message)
            : base(message)
        {
        }
    }

    public class ModkitExportException : Exception
    {
        public ModkitExportException(string message)
            : base(message)
        {
        }
    }
}
