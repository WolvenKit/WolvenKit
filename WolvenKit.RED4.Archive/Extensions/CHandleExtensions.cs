using System.Collections.Generic;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Extensions
{
    public static class CHandleExtensions
    {
        public static IList<IRedClass> Chunks { get; set; }

        public static T GetReference<T>(this CHandle<T> handle) where T : IRedClass => (T)Chunks[handle.Pointer - 1];
    }
}
