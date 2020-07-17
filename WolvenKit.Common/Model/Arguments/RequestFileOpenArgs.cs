using System;
using System.Collections.Generic;

namespace WolvenKit.Common.Model
{
    public class RequestFileArgs : EventArgs
    {
        public string File { get; set; }
        public bool Inspect { get; set; }
    }

    public class RequestFileDeleteArgs : EventArgs
    {
        public List<string> Files { get; set; }
    }

    public class UpdateMonitoringEventArgs : EventArgs
    {
        public bool Monitor { get; set; }

        public UpdateMonitoringEventArgs(bool monitor)
        {
            Monitor = monitor;
        }
    }
    


}