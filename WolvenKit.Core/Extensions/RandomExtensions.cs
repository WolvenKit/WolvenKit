using System;

namespace WolvenKit.Core.Extensions;

public static class RandomExtensions
{
    public static ulong NextCRUID(this Random random)
    {
        var buf = new byte[8];
        random.NextBytes(buf);
        return BitConverter.ToUInt64(buf, 0) & 0xFFFFFFFFFFFFFFFC;
    }
}