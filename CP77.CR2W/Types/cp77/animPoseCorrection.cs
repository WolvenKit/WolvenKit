using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animPoseCorrection : CVariable
	{
		[Ordinal(0)]  [RED("rbfCoefficient")] public CFloat RbfCoefficient { get; set; }
		[Ordinal(1)]  [RED("rbfPowValue")] public CFloat RbfPowValue { get; set; }
		[Ordinal(2)]  [RED("compareBones", lignas(16) StaticArray<animCompareBon, 4)] public alignas(16) StaticArray<animCompareBone> CompareBones { get; set; }
		[Ordinal(3)]  [RED("boneCorrections", lignas(16) StaticArray<animBoneCorrectio, 4)] public alignas(16) StaticArray<animBoneCorrection> BoneCorrections { get; set; }

		public animPoseCorrection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
