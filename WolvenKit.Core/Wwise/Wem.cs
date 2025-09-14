using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace WolvenKit.Core.Wwise;

public static class Wem
{
    public static byte[] Convert(byte[] inBuffer)
    {
        var inBufferSize = (ulong)inBuffer.LongLength;
        var outBufferSize = get_wem_to_ogg_size(inBuffer, inBufferSize);
        if (outBufferSize == 0)
        {
            throw new ExternalException("Failed to compute size of OGG for WEM buffer.");
        }

        var outBuffer = new byte[outBufferSize];
        wem_to_ogg(inBuffer, inBufferSize, outBuffer);
        return outBuffer;
    }

    public static bool TryConvert(byte[] inBuffer, [NotNullWhen(true)] out byte[]? outBuffer)
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
    private static extern ulong get_wem_to_ogg_size(byte[] inData, ulong inSize);

    [DllImport("wwtools")]
    private static extern void wem_to_ogg(byte[] inData, ulong inSize, byte[] outData);
}
