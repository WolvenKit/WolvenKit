using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animSBehaviorConstraintNodeFloorIKVerticalBoneData : CVariable
	{
		[Ordinal(0)]  [RED("Ma")] public offse Ma { get; set; }
		[Ordinal(1)]  [RED("Mi")] public offse Mi { get; set; }
		[Ordinal(2)]  [RED("bone")] public animTransformIndex Bone { get; set; }
		[Ordinal(3)]  [RED("offsetToDesiredBlendTime")] public CFloat OffsetToDesiredBlendTime { get; set; }
		[Ordinal(4)]  [RED("stiffness")] public CFloat Stiffness { get; set; }
		[Ordinal(5)]  [RED("verticalOffsetBlendTime")] public CFloat VerticalOffsetBlendTime { get; set; }

		public animSBehaviorConstraintNodeFloorIKVerticalBoneData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
