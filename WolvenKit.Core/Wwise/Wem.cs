using System;
using System.IO;
using System.Runtime.InteropServices;

namespace WolvenKit.Core.Wwise;

public static class Wem
{
    public static byte[] Convert(byte[] inBuffer)
    {
        IntPtr buffer = Marshal.AllocCoTaskMem(inBuffer.Length * 2); // assume converted size is less than twice the input size
        long outBufferSize = wem_to_ogg(inBuffer, inBuffer.Length, ref buffer);
        byte[] outBuffer = new byte[outBufferSize];
        Marshal.Copy(buffer, outBuffer, 0, (int)outBufferSize);
        Marshal.FreeCoTaskMem(buffer);
        return outBuffer;
    }

    public static void Test()
    {
        byte[] data = File.ReadAllBytes("./test.wem");
        byte[] out_data = new byte[1 << 24];
        IntPtr buffer = Marshal.AllocCoTaskMem(out_data.Length);
        long out_size = wem_to_ogg(data, data.Length, ref buffer);
        byte[] final_out = new byte[out_size];
        Marshal.Copy(buffer, final_out, 0, final_out.Length);
        Marshal.FreeCoTaskMem(buffer);
        Console.WriteLine("Out size: " + out_size);
        Console.WriteLine("Final out length: " + final_out.Length);
        Array.Resize(ref final_out, (int)out_size);
        File.WriteAllBytes("./test.ogg", final_out);
    }

    [DllImport("wwtools")]
    private static extern long wem_to_ogg(
        byte[] inData,
        long inSize,
        ref IntPtr outBuffer);
}
