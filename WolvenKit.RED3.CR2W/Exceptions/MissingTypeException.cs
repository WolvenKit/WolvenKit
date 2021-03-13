using System;

namespace WolvenKit.RED3.CR2W.Types
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
