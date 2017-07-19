using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Render
{
    // Informations about the .buffer file
    public class SVertexBufferInfos
    {
        public uint verticesCoordsOffset = 0;
        public uint uvOffset = 0;
        public uint normalsOffset = 0;

        public uint indicesOffset = 0;

        public ushort nbVertices = 0;
        public uint nbIndices = 0;

        public byte lod = 1;
    };


    public static class ReadMeshData
    {
        public static T[] SubArray<T>(this T[] data, ref int currIndex, int length)
        {
            T[] result = new T[length];
            Array.Copy(data, currIndex, result, 0, length);
            currIndex += length;
            return result;
        }

        public static uint GetUint(this byte[] data)
        {
            if (data.Length == 4)
                return (uint)(data[3] << 24 | data[2] << 16 | data[1] << 8 | data[0] << 0);
            else
                return 0;
        }

        public static ushort GetUshort(this byte[] data)
        {
            if (data.Length == 2)
                return (ushort)(data[1] << 8 | data[0] << 0);
            else
                return 0;
        }

        public static byte GetByte(this byte[] data)
        {
            if (data.Length == 1)
                return data[0];
            else
                return 0;
        }

    }
}
