using System.IO;
using WolvenKit.RED4.CR2W.Reflection;
using FastMember;

// TODO: REDType
namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class animRig : animRig_
    {
        private CBool _skipRigValidation;
        private CArrayCompressed<CInt16> _unk1;
        private CArrayCompressed<CArrayCompressed<Vector4>> _unk2;

        [Ordinal(999)]
        [RED("skipRigValidation")]
        public CBool SkipRigValidation
        {
            get => GetProperty(ref _skipRigValidation);
            set => SetProperty(ref _skipRigValidation, value);
        }

        [Ordinal(1000)]
        [REDBuffer(true)]
        public CArrayCompressed<CInt16> Unk1
        {
            get => GetProperty(ref _unk1);
            set => SetProperty(ref _unk1, value);
        }

        // could be anything, the vector4 is just a wild guess
        [Ordinal(1001)]
        [REDBuffer(true)]
        public CArrayCompressed<CArrayCompressed<Vector4>> Unk2
        {
            get => GetProperty(ref _unk2);
            set => SetProperty(ref _unk2, value);
        }

        public animRig(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            Unk1.ReadWithoutMeta(file, size, BoneNames.Count);
            for (int i = 0; i < BoneNames.Count; i++)
            {
                var floatArray = new CArrayCompressed<Vector4>(cr2w, Unk2, i.ToString());
                floatArray.ReadWithoutMeta(file, 0, 3);
                Unk2.Add(floatArray);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            Unk1.WriteWithoutMeta(file);
            Unk2.WriteWithoutMeta(file);
        }
    }
}
