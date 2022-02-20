using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class TilesBuffer : IParseableBuffer, IRedType
    {
        public IRedType Data => Vertices;
        
        public Vector3 Uk1 = new();

        public Vector3 Min = new();

        public Vector3 Max = new();

        public CFloat Uk2 = new();

        public CArray<Vector3> Vertices = new();

        public CArray<TilesBufferUk1> FaceInfo = new();

        public CArray<TilesBufferUk2> Zeros = new();

        public CArray<TilesBufferUk3> Indices = new();

        public CArray<CUInt32> Flags = new();

        public CArray<TilesBufferUk4> Info = new();

        public TilesBuffer()
        {

        }
    }

    public class TilesBufferUk1 : IRedType
    {
        public CUInt32 Zero;

        public CArray<CUInt16> Indices = new();
    }

    public class TilesBufferUk2 : IRedType
    {
        public CUInt64 Uk1;

        public CUInt64 Uk2;
    }

    public class TilesBufferUk3 : IRedType
    {
        public CUInt32 Uk1;

        public CUInt32 Index;

        public CUInt32 Uk2;
    }

    public class TilesBufferUk4 : IRedType
    {
        public CArray<TilesBufferUk4_1> Uk1 = new();

        public CUInt32 Uk2;
    }

    public class TilesBufferUk4_1 : IRedType
    {
        public CInt8 Value;

        public CInt8 Flag;
    }
}
