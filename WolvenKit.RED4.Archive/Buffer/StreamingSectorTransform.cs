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

        public CUInt64 GUID { get; set; }

        public NodeRef QuestNodeRef { get; set; }

        public NodeRef UkNodeRef { get; set; }

        public NodeRef ExternalNodeRef { get; set; }

        public CFloat Uk8 { get; set; }

        public CFloat Uk9 { get; set; }

        public CUInt16 HandleIndex { get; set; }

        public CUInt16 Uk10 { get; set; }

        public CUInt16 Uk11 { get; set; }

        public CUInt16 Uk12 { get; set; }

        public StreamingSectorTransform()
        {

        }
    }
}
