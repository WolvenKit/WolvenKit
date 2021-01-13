using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CP77.Common.Tools
{
    public static class OodleHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputBuffer"></param>
        /// <param name="outputBuffer"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int Decompress(byte[] inputBuffer, byte[] outputBuffer)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                return OodleNative.OodleLZ_Decompress(inputBuffer, inputBuffer.Length, outputBuffer,
                    outputBuffer.Length, OodleNative.OodleLZ_FuzzSafe.No, OodleNative.OodleLZ_CheckCRC.No,
                    OodleNative.OodleLZ_Verbosity.None, 0, 0, 0, 0, 0, 0, OodleNative.OodleLZ_Decode.Unthreaded);
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return OozNative.Kraken_Decompress(inputBuffer, inputBuffer.Length, outputBuffer,
                    outputBuffer.Length);
            else
                throw new NotImplementedException();
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputBytes"></param>
        /// <param name="inputOffset"></param>
        /// <param name="inputCount"></param>
        /// <param name="outputBytes"></param>
        /// <param name="outputOffset"></param>
        /// <param name="outputCount"></param>
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
            OodleNative.OodleLZ_Compression level = OodleNative.OodleLZ_Compression.Optimal5)
        {
            if (inputBytes == null)
                throw new ArgumentNullException(nameof(inputBytes));
            if (inputCount <= 0 || inputCount > inputBytes.Length)
                throw new ArgumentOutOfRangeException(nameof(inputCount));
            if (outputBuffer == null)
                throw new ArgumentNullException(nameof(outputBuffer));

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                var compressedBufferSizeNeeded = OodleHelper.GetCompressedBufferSizeNeeded((int)inputCount);
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
                    compressedBufferSizeNeeded,
                    IntPtr.Zero,
                    IntPtr.Zero,
                    IntPtr.Zero,
                    IntPtr.Zero,
                    (int)level);
                inputHandle.Free();
                outputHandle.Free();

                //resize buffer
                var writelist = new List<byte>()
                {
                    0x4B, 0x41, 0x52, 0x4B  //KRAKEN, TODO: make this variable and dependent on the compression algo
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
                return (int) OodleNative.GetCompressedBufferSizeNeeded((long) count);
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                try
                {
                    return OozNative.GetCompressedBufferSizeNeeded(count);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            else
                throw new NotImplementedException();
        }
    }
}
