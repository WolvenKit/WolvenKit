using System;
using System.Collections.Generic;

namespace WolvenKit.Common.Model
{
    public class RequestFileDeleteArgs : EventArgs
    {
        public RequestFileDeleteArgs(string file) => Files = new List<string>() { file };

        public RequestFileDeleteArgs(List<string> files) => Files = files;

        public List<string> Files { get; set; }
    }

    public class RequestFileOpenArgs : EventArgs
    {
        public RequestFileOpenArgs(string file) => File = file;


        public string File { get; set; }

        public bool Inspect { get; set; }
    }

    public class RequestFilesChangeArgs : EventArgs
    {
        public RequestFilesChangeArgs(string file) => Files = new List<string>() { file };

        public RequestFilesChangeArgs(List<string> files) => Files = files;

        public List<string> Files { get; set; }
    }
}
