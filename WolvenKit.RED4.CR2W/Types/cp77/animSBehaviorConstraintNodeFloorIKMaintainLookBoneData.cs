using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSBehaviorConstraintNodeFloorIKMaintainLookBoneData : CVariable
	{
		[Ordinal(0)] [RED("bone")] public CName Bone { get; set; }
		[Ordinal(1)] [RED("amountOfRotation")] public CFloat AmountOfRotation { get; set; }

		public animSBehaviorConstraintNodeFloorIKMaintainLookBoneData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
