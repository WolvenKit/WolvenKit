using System;

namespace WolvenKit.Common.Exceptions
{
    public class GameMismatchException : Exception
    {
        public GameMismatchException(string expected, string got) : base($"Game mismatch (Expected:\"{expected}\", Got:\"{got}\")")
        {
        }
    }
}
