using System;
using System.Collections.Generic;

namespace WolvenKit.Common.Model
{
    public class RequestFileDeleteArgs : EventArgs
    {
        #region Constructors

        public RequestFileDeleteArgs(string file)
        {
            Files = new List<string>() { file };
        }

        public RequestFileDeleteArgs(List<string> files)
        {
            Files = files;
        }

        #endregion Constructors

        #region Properties

        public List<string> Files { get; set; }

        #endregion Properties
    }

    public class RequestFileOpenArgs : EventArgs
    {
        #region Properties

        public string File { get; set; }
        public bool Inspect { get; set; }

        #endregion Properties
    }

    public class RequestFilesChangeArgs : EventArgs
    {
        #region Constructors

        public RequestFilesChangeArgs(string file)
        {
            Files = new List<string>() { file };
        }

        public RequestFilesChangeArgs(List<string> files)
        {
            Files = files;
        }

        #endregion Constructors

        #region Properties

        public List<string> Files { get; set; }

        #endregion Properties
    }
}
