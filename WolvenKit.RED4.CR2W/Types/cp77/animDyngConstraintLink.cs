using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDyngConstraintLink : animIDyngConstraint
	{
		[Ordinal(1)] [RED("bone1")] public animTransformIndex Bone1 { get; set; }
		[Ordinal(2)] [RED("bone2")] public animTransformIndex Bone2 { get; set; }
		[Ordinal(3)] [RED("linkType")] public CEnum<animDyngConstraintLinkType> LinkType { get; set; }
		[Ordinal(4)] [RED("lengthLowerBoundRatioPercentage")] public CFloat LengthLowerBoundRatioPercentage { get; set; }
		[Ordinal(5)] [RED("lengthUpperBoundRatioPercentage")] public CFloat LengthUpperBoundRatioPercentage { get; set; }
		[Ordinal(6)] [RED("lookAtAxis")] public Vector3 LookAtAxis { get; set; }

		public animDyngConstraintLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
