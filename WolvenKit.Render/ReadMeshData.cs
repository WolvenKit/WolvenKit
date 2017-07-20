using System;
using System.Collections.Generic;
using IrrlichtLime.Core;

namespace WolvenKit.Render
{
    public class SBufferInfos
    {
        public uint vertexBufferOffset = 0;
        public uint vertexBufferSize = 0;

        public uint indexBufferOffset = 0;
        public uint indexBufferSize = 0;

        public Vector3Df quantizationScale = new Vector3Df(1, 1, 1);
        public Vector3Df quantizationOffset = new Vector3Df(0, 0, 0);

        public List<SVertexBufferInfos> verticesBuffer = new List<SVertexBufferInfos>();
    };

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

    // Information to load a mesh from the buffer
    public class SMeshInfos
    {
        public enum EMeshVertexType
        {
            EMVT_STATIC,
            EMVT_SKINNED
        };

        public uint numVertices = 0;
        public uint numIndices = 0;
        public uint numBonesPerVertex = 4;

        public uint firstVertex = 0;
        public uint firstIndex = 0;

        public EMeshVertexType vertexType = EMeshVertexType.EMVT_STATIC;

        public uint materialID = 0;
    };


    public static class ExtensionMethods
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
