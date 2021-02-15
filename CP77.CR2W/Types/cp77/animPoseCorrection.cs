using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animPoseCorrection : CVariable
	{
		[Ordinal(0)] [RED("rbfCoefficient")] public CFloat RbfCoefficient { get; set; }
		[Ordinal(1)] [RED("rbfPowValue")] public CFloat RbfPowValue { get; set; }
		[Ordinal(2)] [RED("compareBones", 4)] public CStatic<animCompareBone> CompareBones { get; set; }
		[Ordinal(3)] [RED("boneCorrections", 4)] public CStatic<animBoneCorrection> BoneCorrections { get; set; }

		public animPoseCorrection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
