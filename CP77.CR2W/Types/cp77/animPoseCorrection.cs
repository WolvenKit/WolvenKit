using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animPoseCorrection : CVariable
	{
		[Ordinal(0)]  [RED("boneCorrections", 4)] public CStatic<animBoneCorrection> BoneCorrections { get; set; }
		[Ordinal(1)]  [RED("compareBones", 4)] public CStatic<animCompareBone> CompareBones { get; set; }
		[Ordinal(2)]  [RED("rbfCoefficient")] public CFloat RbfCoefficient { get; set; }
		[Ordinal(3)]  [RED("rbfPowValue")] public CFloat RbfPowValue { get; set; }

		public animPoseCorrection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
