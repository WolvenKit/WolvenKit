using System.IO;
using WolvenKit.RED4.CR2W.Reflection;

// TODO: REDType
namespace WolvenKit.RED4.CR2W.Types
{
    public class AreaShapeOutline : AreaShapeOutline_
    {
        private CArrayCompressed<AreaShapeOutline_UnkStruct> _unk1;
        private CFloat _unk2;

        [REDBuffer(true)]
        public CArrayCompressed<AreaShapeOutline_UnkStruct> Unk1
        {
            get => GetProperty(ref _unk1);
            set => SetProperty(ref _unk1, value);
        }

        [REDBuffer(true)]
        public CFloat Unk2
        {
            get => GetProperty(ref _unk2);
            set => SetProperty(ref _unk2, value);
        }

        public AreaShapeOutline(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            var counter = file.ReadInt32();
            Unk1.Read(file, 16, counter);
            Unk2.Read(file, 4);
        }

        public override void Write(BinaryWriter file)
        {
            file.Write(Unk1.Count);
            Unk1.Write(file);
            Unk2.Write(file);
        }
    }

    public class AreaShapeOutline_UnkStruct : CVariable
    {
        private Vector3 _unkPoint;
        private CFloat _unkHeight;

        [REDBuffer(true)]
        public Vector3 UnkPoint
        {
            get => GetProperty(ref _unkPoint);
            set => SetProperty(ref _unkPoint, value);
        }

        [REDBuffer(true)]
        public CFloat UnkHeight
        {
            get => GetProperty(ref _unkHeight);
            set => SetProperty(ref _unkHeight, value);
        }

        public AreaShapeOutline_UnkStruct(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            UnkPoint.X.Read(file, 4);
            UnkPoint.Y.Read(file, 4);
            UnkPoint.Z.Read(file, 4);
            UnkHeight.Read(file, 4);
        }

        public override void Write(BinaryWriter file)
        {
            UnkPoint.X.Write(file);
            UnkPoint.Y.Write(file);
            UnkPoint.Z.Write(file);
            UnkHeight.Write(file);
        }
    }
}
