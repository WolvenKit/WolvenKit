using System;
using DirectXTexNet;

namespace WolvenKit.Common.Extensions;

public static class TexHelperExtensions
{
    public static unsafe ScratchImage LoadFromDDSMemory(this TexHelper tex, byte[] buffer, DirectXTexNet.DDS_FLAGS flags, out TexMetadata metadata)
    {
        fixed (byte* pIn = buffer)
        {
            return TexHelper.Instance.LoadFromDDSMemory((IntPtr)pIn, buffer.Length, flags, out metadata);
        }
    }

    public static unsafe ScratchImage LoadFromTGAMemory(this TexHelper tex, byte[] buffer)
    {
        fixed (byte* pIn = buffer)
        {
            return TexHelper.Instance.LoadFromTGAMemory((IntPtr)pIn, buffer.Length);
        }
    }

    public static unsafe ScratchImage LoadFromWICMemory(this TexHelper tex, byte[] buffer, WIC_FLAGS flags)
    {
        fixed (byte* pIn = buffer)
        {
            return TexHelper.Instance.LoadFromWICMemory((IntPtr)pIn, buffer.Length, flags);
        }
    }
}
