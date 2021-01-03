using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animSBehaviorConstraintNodeFloorIKMaintainLookBoneData : CVariable
	{
		[Ordinal(0)]  [RED("amountOfRotation")] public CFloat AmountOfRotation { get; set; }
		[Ordinal(1)]  [RED("bone")] public CName Bone { get; set; }

		public animSBehaviorConstraintNodeFloorIKMaintainLookBoneData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
