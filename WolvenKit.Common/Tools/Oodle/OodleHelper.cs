using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Tools.Oodle;
using WolvenKit.RED4.Archive;

namespace WolvenKit.Common.Oodle
{
    public static class OodleHelper
    {
        #region Fields

        public const uint KARK = 1263681867;

        #endregion Fields

        // 0x4b, 0x41, 0x52, 0x4b

        #region Methods

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
            OodleNative.OodleLZ_Compression level = OodleNative.OodleLZ_Compression.Normal,
            bool useREDHeader = true)
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

                var result = 0;
                if (true)
                {
                    result = (int)OodleLoadLib.OodleLZ_Compress(
                        inputAddress,
                        outputAddress,
                        inputCount,
                        algo,
                        level
                    );
                }
                else
#pragma warning disable 162
                {
                    result = (int)OodleNative.Compress(
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
                }
#pragma warning restore 162



                inputHandle.Free();
                outputHandle.Free();

                if (result == 0 || inputCount <= (result + 8))
                {
                    outputBuffer = inputBytes;
                    return outputBuffer.Count();
                }


                if (useREDHeader)
                {
                    //resize buffer
                    var writelist = new List<byte>()
                    {
                        0x4B, 0x41, 0x52, 0x4B  //KARK, TODO: make this dependent on the compression algo
                    };
                    writelist.AddRange(BitConverter.GetBytes(inputCount));
                    writelist.AddRange(compressedBuffer.Take(result));

                    outputBuffer = writelist;
                }
                else
                {
                    outputBuffer = compressedBuffer.Take(result);
                }

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

        private static long Decompress(Span<byte> inputBufferSpan, Span<byte> outputBufferSpan)
        {
            unsafe
            {
                fixed (byte* bpi = &inputBufferSpan.GetPinnableReference())
                fixed (byte* bpo = &outputBufferSpan.GetPinnableReference())
                {
                    var pInputBufferSpan = (IntPtr)bpi;
                    var pOutputBufferSpan = (IntPtr)bpo;

                    var r = OodleLoadLib.OodleLZ_Decompress(pInputBufferSpan,
                        pOutputBufferSpan,
                        inputBufferSpan.Length,
                        outputBufferSpan.Length
                    );

                    return r;

                }
            }




        }


        /// <summary>
        /// Wrapper around Oodle Kraken Decompress. Decompresses an inputBuffer to an outputBuffer of correct size
        /// </summary>
        /// <param name="inputBuffer"></param>
        /// <param name="outputBuffer"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static unsafe int Decompress(byte[] inputBuffer, byte[] outputBuffer)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
#pragma warning disable 162

                if (true)
                {
                    var inputHandle = GCHandle.Alloc(inputBuffer, GCHandleType.Pinned);
                    var inputAddress = inputHandle.AddrOfPinnedObject();
                    var outputHandle = GCHandle.Alloc(outputBuffer, GCHandleType.Pinned);
                    var outputAddress = outputHandle.AddrOfPinnedObject();



                    var r = OodleLoadLib.OodleLZ_Decompress(inputAddress,
                        outputAddress,
                        inputBuffer.Length,
                        outputBuffer.Length
                        );

                    inputHandle.Free();
                    outputHandle.Free();

                    return r;
                }

                return OodleNative.OodleLZ_Decompress(
                    inputBuffer,
                    inputBuffer.Length,
                    outputBuffer,
                    outputBuffer.Length,
                    OodleNative.OodleLZ_FuzzSafe.No, OodleNative.OodleLZ_CheckCRC.No,
                    OodleNative.OodleLZ_Verbosity.None,
                    0,
                    0,
                    0,
                    0,
                    0,
                    0,
                    OodleNative.OodleLZ_Decode.Unthreaded);
#pragma warning restore 162

            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return OozNative.Kraken_Decompress(inputBuffer, inputBuffer.Length, outputBuffer,
                    outputBuffer.Length);
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

                    var unpackedSize = OodleHelper.Decompress(inputBufferSpan, outputBufferSpan);
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

                    long unpackedSize = await Task.Run(() => OodleHelper.Decompress(inputBuffer, outputBuffer));

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
        private static int GetCompressedBufferSizeNeeded(int count)
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

        #endregion Methods
    }
}
