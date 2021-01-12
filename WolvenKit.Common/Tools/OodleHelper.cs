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

        // gibbed
        public static int Compress(
            byte[] inputBytes,
            int inputOffset,
            int inputCount,
            byte[] outputBytes,
            int outputOffset,
            int outputCount,
            OodleNative.OodleLZ_Compressor algo = OodleNative.OodleLZ_Compressor.Kraken,
            OodleNative.OodleLZ_Compression level = OodleNative.OodleLZ_Compression.Optimal5)
        {
            if (inputBytes == null)
            {
                throw new ArgumentNullException(nameof(inputBytes));
            }

            if (inputOffset < 0 || inputOffset >= inputBytes.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(inputOffset));
            }

            if (inputCount <= 0 || inputOffset + inputCount > inputBytes.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(inputCount));
            }

            if (outputBytes == null)
            {
                throw new ArgumentNullException(nameof(outputBytes));
            }

            if (outputOffset < 0 || outputOffset >= outputBytes.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(outputOffset));
            }

            if (outputCount <= 0 || outputOffset + outputCount > outputBytes.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(outputCount));
            }

            var inputHandle = GCHandle.Alloc(inputBytes, GCHandleType.Pinned);
            var inputAddress = inputHandle.AddrOfPinnedObject() + inputOffset;
            var outputHandle = GCHandle.Alloc(outputBytes, GCHandleType.Pinned);
            var outputAddress = outputHandle.AddrOfPinnedObject() + outputOffset;
            
            var result = (int)OodleNative.Compress(
                (int)algo,
                inputAddress,
                inputCount,
                outputAddress,
                outputCount,
                IntPtr.Zero,
                IntPtr.Zero,
                IntPtr.Zero,
                IntPtr.Zero,
                (int)level);
            inputHandle.Free();
            outputHandle.Free();
            return result;
        }

        // gibbed
        public static int GetCompressedBufferSizeNeeded(int count)
        {
            return (int)OodleNative.GetCompressedBufferSizeNeeded(count);
        }
    }
}
