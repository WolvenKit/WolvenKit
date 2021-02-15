using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animSBehaviorConstraintNodeFloorIKMaintainLookBoneData : CVariable
	{
		[Ordinal(0)] [RED("bone")] public CName Bone { get; set; }
		[Ordinal(1)] [RED("amountOfRotation")] public CFloat AmountOfRotation { get; set; }

		public animSBehaviorConstraintNodeFloorIKMaintainLookBoneData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
