using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace WolvenKit.Common.Oodle
{
    public static class OodleHelper
    {
        public const uint KARK = 1263681867; // 0x4b, 0x41, 0x52, 0x4b


        /// <summary>
        /// Wrapper around Oodle Kraken Decompress. Decompresses an inputBuffer to an outputBuffer of correct size
        /// </summary>
        /// <param name="inputBuffer"></param>
        /// <param name="outputBuffer"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int Decompress(byte[] inputBuffer, byte[] outputBuffer)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var r = OodleNative.OodleLZ_Decompress(inputBuffer, inputBuffer.Length, outputBuffer,
                    outputBuffer.Length, OodleNative.OodleLZ_FuzzSafe.No, OodleNative.OodleLZ_CheckCRC.No,
                    OodleNative.OodleLZ_Verbosity.None, 0, 0, 0, 0, 0, 0, OodleNative.OodleLZ_Decode.Unthreaded);
                return r;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {

                var r = OozNative.Kraken_Decompress(inputBuffer, inputBuffer.Length, outputBuffer,
                    outputBuffer.Length);
                return r;
            }
            else
            {
                throw new NotImplementedException();
            }
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="inputBytes"></param>
        /// <param name="inputCount"></param>
        /// <param name="outputBuffer"></param>
        /// <param name="algo"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="NotImplementedException"></exception>
        public static int Compress(
            byte[] inputBytes,
            // int inputOffset,
            int inputCount,
            ref IEnumerable<byte> outputBuffer,
            // int outputOffset,
            // int outputCount,
            OodleNative.OodleLZ_Compressor algo = OodleNative.OodleLZ_Compressor.Kraken,
            OodleNative.OodleLZ_Compression level = OodleNative.OodleLZ_Compression.Normal)
        {
            if (inputBytes == null)
            {
                throw new ArgumentNullException(nameof(inputBytes));
            }

            if (inputCount <= 0 || inputCount > inputBytes.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(inputCount));
            }

            if (outputBuffer == null)
            {
                throw new ArgumentNullException(nameof(outputBuffer));
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var compressedBufferSizeNeeded = OodleHelper.GetCompressedBufferSizeNeeded(inputCount);
                var compressedBuffer = new byte[compressedBufferSizeNeeded];

                var inputHandle = GCHandle.Alloc(inputBytes, GCHandleType.Pinned);
                var inputAddress = inputHandle.AddrOfPinnedObject();
                var outputHandle = GCHandle.Alloc(compressedBuffer, GCHandleType.Pinned);
                var outputAddress = outputHandle.AddrOfPinnedObject();

                var result = (int)OodleNative.Compress(
                    (int)algo,
                    inputAddress,
                    inputCount,
                    outputAddress,
                    (int)level,
                    IntPtr.Zero,
                    IntPtr.Zero,
                    IntPtr.Zero,
                    IntPtr.Zero,
                    0
                    );

                inputHandle.Free();
                outputHandle.Free();

                //resize buffer
                var writelist = new List<byte>()
                {
                    0x4B, 0x41, 0x52, 0x4B  //KARK, TODO: make this dependent on the compression algo
                };
                writelist.AddRange(BitConverter.GetBytes(inputCount));
                writelist.AddRange(compressedBuffer.Take(result));

                outputBuffer = writelist;

                return outputBuffer.Count();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                //TODO: use ooz to compress
                outputBuffer = inputBytes;
                return outputBuffer.Count();


                // try
                // {
                //     var result = OozNative.Compress(
                //         (int)algo,
                //         inputAddress,
                //         outputAddress,
                //         inputCount,
                //         IntPtr.Zero,
                //         IntPtr.Zero
                //     );
                //     inputHandle.Free();
                //     outputHandle.Free();
                //     return result;
                // }
                // catch (Exception e)
                // {
                //     Console.WriteLine(e);
                //     throw;
                // }
            }
            else
            {
                throw new NotImplementedException();
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
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                try
                {
                    return OozNative.GetCompressedBufferSizeNeeded(count);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            else
            {
                throw new NotImplementedException();
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
        public static void DecompressAndCopySegment(this Stream stream, Stream outStream, uint zSize, uint size)
        {
            if (zSize == size)
            {
                stream.CopyTo(outStream);
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

                    long unpackedSize = OodleHelper.Decompress(inputBuffer, outputBuffer);

                    if (unpackedSize != size)
                    {
                        throw new DecompressionException(
                            $"Unpacked size {unpackedSize} doesn't match real size {size}");
                    }

                    outStream.Write(outputBuffer);

                    // try
                    // {
                    //
                    // }
                    // catch (DecompressionException)
                    // {
                    //     //logger.LogString(e.Message, Logtype.Error);
                    //     //logger.LogString(
                    //     //    $"Unable to decompress file {hash.ToString()}. Exporting uncompressed file",
                    //     //    Logtype.Error);
                    //     stream.CopyTo(outStream);
                    // }

                }
                else
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    stream.CopyTo(outStream);
                }
            }
        }
    }
}
