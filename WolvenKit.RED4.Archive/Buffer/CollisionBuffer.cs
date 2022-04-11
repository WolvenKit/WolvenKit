using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class CollisionBuffer : IParseableBuffer
    {
        public IRedType Data => null;

        public List<CollisionActor> Actors = new();

        public List<CollisionShape> Shapes = new();

        public List<ulong> Materials = new();

        public List<ulong> Presets = new();

        public CollisionBuffer()
        {

        }
    }

    public class CollisionActor
    {
        public WorldPosition Position;
        public Quaternion Orientation;
        public ushort Shape;
        public short Uk1;
        public short Uk2;
        public short Uk3;
        public ulong Uk4;
    }

    public class CollisionShape
    {
        public ulong Hash;
        public Vector3 Scale;
        public uint Unk1;
        public ushort Index;
        public ushort Uk2;
        public Vector3 Position;
        public ulong Preset;
        public ulong Material;
    }
}
