using System;
using System.Collections.Generic;

namespace WolvenKit.Common.Model.Arguments
{
    public class RequestFileOpenArgs : EventArgs
    {
        public string File { get; set; }
        public bool Inspect { get; set; }
    }

    public class RequestFilesChangeArgs : EventArgs
    {
        public List<string> Files { get; set; }

        public RequestFilesChangeArgs(string file)
        {
            Files = new List<string>() {file};
        }

        public RequestFilesChangeArgs(List<string> files)
        {
            Files = files;
        }
    }

    public class RequestFileDeleteArgs : EventArgs
    {
        public List<string> Files { get; set; }
        public RequestFileDeleteArgs(string file)
        {
            Files = new List<string>() { file };
        }

        public RequestFileDeleteArgs(List<string> files)
        {
            Files = files;
        }
    }

    
    


}