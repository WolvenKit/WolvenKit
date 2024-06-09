using System;
using System.Runtime;

namespace WolvenKit.Core.Helpers;

public static class GcHelper
{
    public static void CleanupMemory()
    {
        // Setting LargeObjectHeapCompactionMode to CompactOnce
        // Will ask GC to collect garbage from LOH ONCE.
        GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
            
        // Since a lot of stuff is unoptimized right now - just ask GC to clear everything aggressivly.
        GC.Collect(GC.MaxGeneration, GCCollectionMode.Aggressive, true, true);
    }
}