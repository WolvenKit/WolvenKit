using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamSpeedTreeWind : meshMeshParameter
	{
        [Ordinal(0)] [REDBuffer] public CUInt32 Unk1 { get; set; }
        [Ordinal(1)] [REDBuffer(true)] public CArrayCompressed<CFloat> Unk2 { get; set; }

        public meshMeshParamSpeedTreeWind(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Unk2 = new CArrayCompressed<CFloat>(cr2w, this, nameof(Unk2)) {IsSerialized = true};
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            if (Unk1.val != 1)
            {
                throw new InvalidParsingException(nameof(meshMeshParamSpeedTreeWind));
            }

            if (size != 991)
            {
                throw new InvalidParsingException(nameof(meshMeshParamSpeedTreeWind));
            }

            Unk2.Read(file, 984, 246);

        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            var elementCount = Unk2.Elements.Count;
            if (elementCount < 246)
            {
                for (int i = elementCount; i < 246; i++)
                {
                    Unk2.AddVariable(new CFloat(cr2w, Unk2, i.ToString()) {IsSerialized = true, val = 0});
                }
            }
            else if (elementCount > 246)
            {
                Unk2.Elements.RemoveRange(246 + 1, elementCount - 246);
            }

            Unk2.Write(file);
        }
    }
}
