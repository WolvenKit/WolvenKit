using System;
using System.IO;

namespace WolvenKit.RED4.Types.Compression
{
    public static class OodleLZHelper
    {
        public enum Status
        {
            Uncompressed,
            Compressed
        }

        private const uint KARK = 1263681867;

        public static Status CompressBuffer(byte[] rawBuf, out byte[] compBuf)
        {
            if (rawBuf.Length > 256)
            {
                var compressedBufferSizeNeeded = OodleLZNative.GetCompressedBufferSizeNeeded(rawBuf.Length);
                var compressedBuffer = new byte[compressedBufferSizeNeeded];
                var compressedSize = OodleLZNative.Compress(OodleLZNative.Compressor.Kraken, rawBuf, rawBuf.Length, compressedBuffer, OodleLZNative.CompressionLevel.Optimal2);
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

                OodleLZNative.Decompress(compressedData, compressedData.Length, rawBuf, rawBuf.Length, OodleLZNative.FuzzSafe.No);
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
