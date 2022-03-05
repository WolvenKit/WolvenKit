using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class StreamingSectorTransform
    {
        public Vector4 Position = new();

        public Quaternion Orientation = new();

        public Vector3 Scale = new();

        public Vector3 Uk1 = new();

        public Vector3 Uk2 = new();

        public Vector3 Uk3 = new();

        public CInt32 Uk4;

        public CInt32 Uk5;

        // 24 byte padding?

        public CUInt64 Mask;

        public CUInt16 HandleIndex;

        public CUInt16 Uk6;

        public CUInt16 Uk7;

        public CUInt16 Uk8;

        public StreamingSectorTransform()
        {

        }
    }
}
