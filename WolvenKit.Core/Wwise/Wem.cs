using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.InteropServices;

namespace WolvenKit.Core.Wwise;

public static class Wem
{
    public static byte[] Convert(byte[] inBuffer)
    {
        var buffer = Marshal.AllocCoTaskMem(inBuffer.Length * 2); // assume converted size is less than twice the input size
        var outBufferSize = wem_to_ogg(inBuffer, inBuffer.Length, ref buffer);
        var outBuffer = new byte[outBufferSize];
        Marshal.Copy(buffer, outBuffer, 0, (int)outBufferSize);
        Marshal.FreeCoTaskMem(buffer);
        return outBuffer;
    }

    public static bool TryConvert(byte[] inBuffer, [NotNullWhen(true)]out byte[]? outBuffer)
    {
        try
        {
            outBuffer = Convert(inBuffer);
            return true;
        }
        catch (Exception)
        {
            outBuffer = null;
            return false;
        }
    }

    [DllImport("wwtools")]
    private static extern long wem_to_ogg(
        byte[] inData,
        long inSize,
        ref IntPtr outBuffer);
}
