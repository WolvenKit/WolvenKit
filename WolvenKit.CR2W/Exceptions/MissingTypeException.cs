using System;

namespace WolvenKit.CR2W.Types
{
    public class MissingTypeException : Exception
    {
        #region Constructors

        public MissingTypeException(string message) : base(message)
        {
        }

        #endregion Constructors
    }
}
