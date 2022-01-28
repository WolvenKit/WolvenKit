#define USE_LIB

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using WolvenKit.Core.Extensions;

namespace WolvenKit.Core.Compression;

public static class Oodle
{
    public enum Status
    {
        Uncompressed,
        Compressed
    }
    
    public const uint KARK = 1263681867; // 0x4b, 0x41, 0x52, 0x4b

    public static bool IsCompressed(byte[] buf) => buf.Length >= 4 && buf[0] == 0x4B && buf[1] == 0x41 && buf[2] == 0x52 && buf[3] == 0x4B;

    public static Status CompressBuffer(byte[] rawBuf, out byte[] compBuf)
    {
        if (rawBuf.Length > 256)
        {
#if USE_LIB
            var compressedBufferSizeNeeded = GetCompressedBufferSizeNeeded(rawBuf.Length);
#else
            var compressedBufferSizeNeeded = OodleLZNative.GetCompressedBufferSizeNeeded(rawBuf.Length);
#endif

            var compressedBuffer = new byte[compressedBufferSizeNeeded];

#if USE_LIB
            var compressedSize = OodleLib.OodleLZ_Compress(rawBuf, compressedBuffer, OodleLZNative.Compressor.Kraken, OodleLZNative.CompressionLevel.Optimal2);
#else
            var compressedSize = OodleLZNative.Compress(OodleLZNative.Compressor.Kraken, rawBuf, rawBuf.Length, compressedBuffer, OodleLZNative.CompressionLevel.Optimal2);
#endif

            var outArray = new byte[compressedSize + 8];

            Array.Copy(BitConverter.GetBytes(KARK), 0, outArray, 0, 4);
            Array.Copy(BitConverter.GetBytes(rawBuf.Length), 0, outArray, 4, 4);
            Array.Copy(compressedBuffer, 0, outArray, 8, compressedSize);

            if (rawBuf.Length > outArray.Length)
            {
                compBuf = outArray;
                return Status.Compressed;
            }
        }

        compBuf = rawBuf;
        return Status.Uncompressed;
    }

    public static void DecompressBuffer(byte[] compBuf, out byte[] rawBuf)
    {
        using var ms = new MemoryStream(compBuf);
        using var br = new BinaryReader(ms);

        var header = br.ReadUInt32();
        if (header == KARK)
        {
            var size = br.ReadUInt32();

            var compressedData = br.ReadBytes(compBuf.Length - 8);
            rawBuf = new byte[size];

#if USE_LIB
            OodleLib.OodleLZ_Decompress(compBuf, rawBuf);
#else
            OodleLZNative.Decompress(compressedData, compressedData.Length, rawBuf, rawBuf.Length, OodleLZNative.FuzzSafe.No);
#endif
        }
        else
        {
            throw new Exception();
        }
    }

    public static int Compress( byte[] inputBuffer, ref IEnumerable<byte> outputBuffer,
        bool useREDHeader = true,
        OodleLZNative.CompressionLevel level = OodleLZNative.CompressionLevel.Normal,
        OodleLZNative.Compressor compressor = OodleLZNative.Compressor.Kraken)
    {
        if (inputBuffer == null)
        {
            throw new ArgumentNullException(nameof(inputBuffer));
        }
        var inputCount = inputBuffer.Length;
        if (inputCount <= 0 || inputCount > inputBuffer.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(inputCount));
        }
        if (outputBuffer == null)
        {
            throw new ArgumentNullException(nameof(outputBuffer));
        }

        var result = 0;
        var compressedBufferSizeNeeded = Oodle.GetCompressedBufferSizeNeeded(inputCount);
        var compressedBuffer = new byte[compressedBufferSizeNeeded];

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
#if USE_LIB
            result = OodleLib.OodleLZ_Compress(inputBuffer, compressedBuffer, compressor, level);
#else
            result = OodleLZNative.Compress(OodleLZNative.Compressor.Kraken, inputBuffer, inputBuffer.Length, compressedBuffer, level);
#endif
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            throw new NotImplementedException();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            throw new NotImplementedException();
        }
        else 
        {
            throw new NotImplementedException();
        }


        if (result == 0 || inputCount <= (result + 8))
        {
            outputBuffer = inputBuffer;
            return outputBuffer.Count();
        }

        if (useREDHeader)
        {
            // write KARK header
            var writelist = new List<byte>()
                    {
                        0x4B, 0x41, 0x52, 0x4B  //KARK, TODO: make this dependent on the compression algo
                    };
            // write size
            writelist.AddRange(BitConverter.GetBytes(inputCount));
            // write compressed data
            writelist.AddRange(compressedBuffer.Take(result));

            outputBuffer = writelist;
        }
        else
        {
            outputBuffer = compressedBuffer.Take(result);
        }

        return outputBuffer.Count();
    }

    private static long Decompress(Span<byte> inputBufferSpan, Span<byte> outputBufferSpan)
    {
        var result = 0;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
#if USE_LIB
            result = OodleLib.OodleLZ_Decompress(inputBufferSpan.ToArray(), outputBufferSpan.ToArray());
#else
            var compressedData = inputBufferSpan.ToArray();
            var rawBuf = outputBufferSpan.ToArray();
            result = OodleLZNative.Decompress(compressedData, compressedData.Length, rawBuf, rawBuf.Length, OodleLZNative.FuzzSafe.No);
#endif
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            throw new NotImplementedException();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            throw new NotImplementedException();
        }
        else
        {
            throw new NotImplementedException();
        }

        return result;

        //unsafe
        //{
        //    fixed (byte* bpi = &inputBufferSpan.GetPinnableReference())
        //    fixed (byte* bpo = &outputBufferSpan.GetPinnableReference())
        //    {
        //        var pInputBufferSpan = (IntPtr)bpi;
        //        var pOutputBufferSpan = (IntPtr)bpo;

        //        var r = OodleLib.OodleLZ_Decompress(pInputBufferSpan,
        //            pOutputBufferSpan,
        //            inputBufferSpan.Length,
        //            outputBufferSpan.Length
        //        );

        //        return r;

        //    }
        //}
    }

    public static unsafe int Decompress(byte[] inputBuffer, byte[] outputBuffer)
    {
        var result = 0;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
#if USE_LIB
            result = OodleLib.OodleLZ_Decompress(inputBuffer, outputBuffer);
#else
            
#endif
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            throw new NotImplementedException();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            throw new NotImplementedException();
        }
        else
        {
            throw new NotImplementedException();
        }

        return result;
    }

    /// <summary>
    /// Decompresses and copies a segment of zsize bytes from a stream to another stream
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="outStream"></param>
    /// <param name="zSize"></param>
    /// <param name="size"></param>
    /// <exception cref="Exception"></exception>
    /// <exception cref="DecompressionException"></exception>
    public static void DecompressAndCopySegment(this Stream stream, Stream outStream, uint zSize, uint size)
    {
        if (zSize == size)
        {
            stream.CopyToWithLength(outStream, (int)zSize);
        }
        else
        {
            var oodleCompression = stream.ReadStruct<uint>();
            if (oodleCompression == KARK)
            {
                var headerSize = stream.ReadStruct<uint>();
                if (headerSize != size)
                {
                    throw new DecompressionException($"Buffer size doesn't match size in info table. {headerSize} vs {size}");
                }

                const int SPAN_LEN = 5333;//32768;
                var length = (int)zSize - 8;

                var inputBufferSpan = length <= SPAN_LEN
                    ? stackalloc byte[length]
                    : new byte[length];
                var outputBufferSpan = size <= SPAN_LEN ? stackalloc byte[(int)size] : new byte[size];

                stream.Read(inputBufferSpan);

                var unpackedSize = Oodle.Decompress(inputBufferSpan, outputBufferSpan);
                if (unpackedSize != size)
                {
                    throw new DecompressionException(
                        $"Unpacked size {unpackedSize} doesn't match real size {size}.");
                }

                outStream.Write(outputBufferSpan);
            }
            else
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyToWithLength(outStream, (int)zSize);
            }
        }
    }

    /// <summary>
    /// Decompresses and copies a segment of zsize bytes from a stream to another stream
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="outStream"></param>
    /// <param name="zSize"></param>
    /// <param name="size"></param>
    /// <exception cref="Exception"></exception>
    /// <exception cref="DecompressionException"></exception>
    public static async Task DecompressAndCopySegmentAsync(this Stream stream, Stream outStream, uint zSize, uint size)
    {
        if (zSize == size)
        {
            stream.CopyToWithLength(outStream, (int)zSize);
        }
        else
        {
            var oodleCompression = stream.ReadStruct<uint>();
            if (oodleCompression == KARK)
            {
                var headerSize = stream.ReadStruct<uint>();
                if (headerSize != size)
                {
                    throw new Exception($"Buffer size doesn't match size in info table. {headerSize} vs {size}");
                }

                var inputBuffer = new byte[(int)zSize - 8];

                stream.Read(inputBuffer);
                var outputBuffer = new byte[size];

                long unpackedSize = await Task.Run(() => Oodle.Decompress(inputBuffer, outputBuffer));

                if (unpackedSize != size)
                {
                    throw new DecompressionException(
                        $"Unpacked size {unpackedSize} doesn't match real size {size}.");
                }

                outStream.Write(outputBuffer);
            }
            else
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyToWithLength(outStream, (int)zSize);
            }
        }
    }



    /// <summary>
    /// Gets the max buffer size needed for oodle compression
    /// </summary>
    /// <param name="count"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static int GetCompressedBufferSizeNeeded(int count)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            var n = ((count + 0x3ffff + ((uint)(count + 0x3ffff >> 0x3f) & 0x3ffff))
                    >> 0x12) * 0x112 + count;
            //var n  = OodleNative.GetCompressedBufferSizeNeeded((long)count);
            return (int)n;
        }
        // else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        // {
        //     try
        //     {
        //         return OozNative.GetCompressedBufferSizeNeeded(count);
        //     }
        //     catch (Exception e)
        //     {
        //         Console.WriteLine(e);
        //         throw;
        //     }
        // }
        else
        {
            throw new NotImplementedException();
        }
    }

}
