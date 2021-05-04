using System;

namespace WolvenKit.Interfaces.Core
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
