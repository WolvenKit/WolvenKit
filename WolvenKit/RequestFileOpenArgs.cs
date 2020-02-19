using System;

namespace WolvenKit
{
    public class RequestFileArgs : EventArgs
    {
        public string File { get; set; }
    }

    public class RequestImportArgs : EventArgs
    {
        public string File { get; set; }
        public string Extension { get; set; }
    }
}