using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animSTwoBonesIKSolverData : CVariable
	{
		[Ordinal(0)]  [RED("Join")] public be Join { get; set; }
		[Ordinal(1)]  [RED("Join")] public be Join { get; set; }
		[Ordinal(2)]  [RED("Join")] public be Join { get; set; }
		[Ordinal(3)]  [RED("Join")] public si Join { get; set; }
		[Ordinal(4)]  [RED("Join")] public si Join { get; set; }
		[Ordinal(5)]  [RED("Join")] public si Join { get; set; }
		[Ordinal(6)]  [RED("Join")] public to-ne Join { get; set; }
		[Ordinal(7)]  [RED("Join")] public to-ne Join { get; set; }
		[Ordinal(8)]  [RED("Join")] public to-ne Join { get; set; }
		[Ordinal(9)]  [RED("allowToLock")] public CBool AllowToLock { get; set; }
		[Ordinal(10)]  [RED("autoSetupDirs")] public CBool AutoSetupDirs { get; set; }
		[Ordinal(11)]  [RED("ikBone")] public animTransformIndex IkBone { get; set; }
		[Ordinal(12)]  [RED("jointBone")] public animTransformIndex JointBone { get; set; }
		[Ordinal(13)]  [RED("jointSideWeightJoint")] public CFloat JointSideWeightJoint { get; set; }
		[Ordinal(14)]  [RED("jointSideWeightLower")] public CFloat JointSideWeightLower { get; set; }
		[Ordinal(15)]  [RED("jointSideWeightUpper")] public CFloat JointSideWeightUpper { get; set; }
		[Ordinal(16)]  [RED("limitToLengthPercentage")] public CFloat LimitToLengthPercentage { get; set; }
		[Ordinal(17)]  [RED("lowerBone")] public animTransformIndex LowerBone { get; set; }
		[Ordinal(18)]  [RED("reverseBend")] public CBool ReverseBend { get; set; }
		[Ordinal(19)]  [RED("subLowerBone")] public animTransformIndex SubLowerBone { get; set; }
		[Ordinal(20)]  [RED("upperBone")] public animTransformIndex UpperBone { get; set; }

		public animSTwoBonesIKSolverData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
