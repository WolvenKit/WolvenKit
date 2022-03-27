using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    // this might just be worldNodeEditorData
    public class StreamingSectorTransform : IRedType
    {
        public CUInt64 Id { get; set; }

        public CUInt16 HandleIndex { get; set; }

        public Vector4 Position { get; set; } = new();

        public Quaternion Orientation { get; set; } = new();

        public Vector3 Scale { get; set; } = new();

        public Vector3 Pivot { get; set; } = new();

        public Vector3 Uk2 { get; set; } = new();

        public Vector3 Uk3 { get; set; } = new();

        public NodeRef QuestPrefabRefHash { get; set; }

        public NodeRef UkHash1 { get; set; }

        public NodeRef UkHash2 { get; set; }

        public CFloat MaxStreamingDistance { get; set; }

        public CUInt32 VariantID { get; set; }

        // likely a bitfield

        public CUInt16 Uk10 { get; set; }

        public CUInt16 Uk11 { get; set; }

        public CUInt16 Uk12 { get; set; }

        public StreamingSectorTransform()
        {

        }
    }
}
