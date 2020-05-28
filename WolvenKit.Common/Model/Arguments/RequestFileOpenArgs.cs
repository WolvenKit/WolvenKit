using System;

namespace WolvenKit.Common.Model
{
    public class RequestFileArgs : EventArgs
    {
        public string File { get; set; }
        public bool Inspect { get; set; }
    }

    
}