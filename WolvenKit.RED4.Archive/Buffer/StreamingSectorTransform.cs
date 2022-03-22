using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class StreamingSectorTransform : IRedType
    {
        public Vector4 Position { get; set; } = new();

        public Quaternion Orientation { get; set; } = new();

        public Vector3 Scale { get; set; } = new();

        public Vector3 Uk1 { get; set; } = new();

        public Vector3 Uk2 { get; set; } = new();

        public Vector3 Uk3 { get; set; } = new();

        public CInt32 Uk4 { get; set; }

        public CInt32 Uk5 { get; set; }

        // 24 byte padding?

        public CUInt64 Mask { get; set; }

        public CUInt16 HandleIndex { get; set; }

        public CUInt16 Uk6 { get; set; }

        public CUInt16 Uk7 { get; set; }

        public CUInt16 Uk8 { get; set; }

        public StreamingSectorTransform()
        {

        }
    }
}
