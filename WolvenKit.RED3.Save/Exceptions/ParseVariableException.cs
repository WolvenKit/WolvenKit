using System;

namespace WolvenKit.W3SavegameEditor.Core.Exceptions
{
    [Serializable]
    public class ParseVariableException : Exception
    {
        #region Constructors

        public ParseVariableException()
        {
        }

        public ParseVariableException(string message) : base(message)
        {
        }

        public ParseVariableException(string message, Exception inner) : base(message, inner)
        {
        }

        #endregion Constructors
    }
}
