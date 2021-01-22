using System.IO;
using System.Runtime.InteropServices;
using WolvenKit.Common;

namespace CP77.Common.Image
{
    public static class BlockCompression
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        private struct BC4_UNORM
        {

            public float R(int offset)
            {
                uint index = GetIndex(offset);
                return DecodeFromIndex(index);
            }

            float DecodeFromIndex(uint index)
            {
                if (index == 0)
                    return red_0 / 255.0f;
                if (index == 1)
                    return red_1 / 255.0f;
                float fred_0 = red_0 / 255.0f;
                float fred_1 = red_1 / 255.0f;

                if(red_0 > red_1)
                {
                    index--;
                    return (fred_0 * ((float)7 - index) + fred_1 * index) / 7.0f;
                }
                else
                {
                    if (index == 6)
                        return 0.0f;
                    if (index == 7)
                        return 1.0f;
                    index--;
                    return (fred_0 * ((float)5 - index) + fred_1 * index) / 5.0f;
                }
            }

            uint GetIndex(int offset)
            {
                return (uint)(data >> (3 * offset + 16)) & 0x07;
            }
            [FieldOffset(0)] ulong data;

            [FieldOffset(0)] byte red_0;
            [FieldOffset(1)] byte red_1;
            
            [FieldOffset(2)] byte index0;
            [FieldOffset(3)] byte index1;
            [FieldOffset(4)] byte index2;
            [FieldOffset(5)] byte index3;
            [FieldOffset(6)] byte index4;
            [FieldOffset(7)] byte index5;

            
        }

        //Do we care about BC U and S norm difference?

        public enum BlockCompressionType
        {
            BC1,
            BC2,
            BC3,
            BC4,
            BC5,
            BC7
        }

        public static bool DecodeBC(byte[] data, ref byte[] dataRaw, uint width, uint height, BlockCompressionType bcType)
        {
            switch (bcType)
            {
                case BlockCompressionType.BC4:
                    DecodeBC4Inner(data, ref dataRaw, width, height);
                    break;
                case BlockCompressionType.BC1:
                case BlockCompressionType.BC2:
                case BlockCompressionType.BC3:
                case BlockCompressionType.BC5:
                case BlockCompressionType.BC7:
                default:
                    return false;
            }
            return true;
        }

        private static void DecodeBC4Inner(byte[] data, ref byte[] dataRaw, uint width, uint height)
        {
            dataRaw = new byte[width * height];
            MemoryStream ms = new MemoryStream(data);
            BinaryReader br = new BinaryReader(ms);

            uint blocksPerLine = width / 4;
            BC4_UNORM[] blocks = br.BaseStream.ReadStructs<BC4_UNORM>((uint)data.Length / 8U);
            uint xOffset = 0;
            uint yOffset = 0;
            for(int i = 0;i<blocks.Length;i++)
            {
                //This could be a lot neater
                dataRaw[xOffset + 0 + (yOffset + 0) * width] = (byte)(blocks[i].R(0) * 255.0f);
                dataRaw[xOffset + 1 + (yOffset + 0) * width] = (byte)(blocks[i].R(1) * 255.0f);
                dataRaw[xOffset + 2 + (yOffset + 0) * width] = (byte)(blocks[i].R(2) * 255.0f);
                dataRaw[xOffset + 3 + (yOffset + 0) * width] = (byte)(blocks[i].R(3) * 255.0f);

                dataRaw[xOffset + 0 + (yOffset + 1) * width] = (byte)(blocks[i].R(4) * 255.0f);
                dataRaw[xOffset + 1 + (yOffset + 1) * width] = (byte)(blocks[i].R(5) * 255.0f);
                dataRaw[xOffset + 2 + (yOffset + 1) * width] = (byte)(blocks[i].R(6) * 255.0f);
                dataRaw[xOffset + 3 + (yOffset + 1) * width] = (byte)(blocks[i].R(7) * 255.0f);

                dataRaw[xOffset + 0 + (yOffset + 2) * width] = (byte)(blocks[i].R(8) * 255.0f);
                dataRaw[xOffset + 1 + (yOffset + 2) * width] = (byte)(blocks[i].R(9) * 255.0f);
                dataRaw[xOffset + 2 + (yOffset + 2) * width] = (byte)(blocks[i].R(10) * 255.0f);
                dataRaw[xOffset + 3 + (yOffset + 2) * width] = (byte)(blocks[i].R(11) * 255.0f);

                dataRaw[xOffset + 0 + (yOffset + 3) * width] = (byte)(blocks[i].R(12) * 255.0f);
                dataRaw[xOffset + 1 + (yOffset + 3) * width] = (byte)(blocks[i].R(13) * 255.0f);
                dataRaw[xOffset + 2 + (yOffset + 3) * width] = (byte)(blocks[i].R(14) * 255.0f);
                dataRaw[xOffset + 3 + (yOffset + 3) * width] = (byte)(blocks[i].R(15) * 255.0f);

                xOffset += 4;
                if(xOffset == width)
                {
                    xOffset = 0;
                    yOffset += 4;
                }
            }
        }
    }
}
