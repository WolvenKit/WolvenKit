using System;

namespace WolvenKit
{
    public class RequestFileArgs : EventArgs
    {
        public string File { get; set; }
        public bool Inspect { get; set; }
    }

    
}