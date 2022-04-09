using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class CollisionBuffer : IParseableBuffer
    {
        public IRedType Data => null;

        public CArray<CollisionActor> Actors { get; set; } = new();

        public CArray<CollisionShape> Shapes { get; set; } = new();

        public CArray<CUInt64> Materials { get; set; } = new();

        public CArray<CUInt64> Presets { get; set; } = new();

        public CArray<CUInt32> ShapeIndices { get; set; } = new();

        public CArray<CUInt8> MaterialIndices { get; set; } = new();

        public CollisionBuffer()
        {

        }
    }

    public class CollisionActor : IRedType
    {
        public WorldPosition Position { get; set; } = new();
        public Quaternion Orientation { get; set; } = new();
        public CUInt16 ShapeIndexStart {  get; set; }
        public CUInt16 NumShapes { get; set; }
        public CArray<CollisionShape> Shapes { get; set; } = new();
        public Vector3 Scale { get; set; } = new();
        public CInt16 Uk1 { get; set; }
        public CUInt64 Uk2 { get; set; }
    }

    public class CollisionShape : IRedType
    {
        public CEnum<physicsShapeType> ShapeType { get; set; }
        public Vector3 Size { get; set; } = new();
        public CUInt64 Hash { get; set; }
        public CUInt16 Index { get; set; }
        public Vector3 Position { get; set; } = new();
        public Quaternion Rotation { get; set; } = new();
        public CUInt64 Preset { get; set; }
        public CEnum<physicsProxyType> ProxyType { get; set; }
        public CUInt64 Material { get; set; }
        public CArray<IRedType> Uks { get; set; } = new();
    }
}
