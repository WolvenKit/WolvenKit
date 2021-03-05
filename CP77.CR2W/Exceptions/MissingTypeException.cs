using System;

namespace CP77.CR2W.Types
{
    public class MissingTypeException : Exception
    {
        #region Constructors

        public MissingTypeException(string typename) : base($"Missing Type '{typename}'")
        {
        }

        #endregion Constructors
    }
}
