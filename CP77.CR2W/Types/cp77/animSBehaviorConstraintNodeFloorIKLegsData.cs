using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animSBehaviorConstraintNodeFloorIKLegsData : CVariable
	{
		[Ordinal(0)]  [RED("Ma")] public ang Ma { get; set; }
		[Ordinal(1)]  [RED("Ma")] public ang Ma { get; set; }
		[Ordinal(2)]  [RED("Ma")] public ang Ma { get; set; }
		[Ordinal(3)]  [RED("Ma")] public distan Ma { get; set; }
		[Ordinal(4)]  [RED("Ma")] public r Ma { get; set; }
		[Ordinal(5)]  [RED("Ma")] public tra Ma { get; set; }
		[Ordinal(6)]  [RED("Mi")] public r Mi { get; set; }
		[Ordinal(7)]  [RED("Mi")] public tra Mi { get; set; }
		[Ordinal(8)]  [RED("verticalOffsetBlendDownTime")] public CFloat VerticalOffsetBlendDownTime { get; set; }
		[Ordinal(9)]  [RED("verticalOffsetBlendUpTime")] public CFloat VerticalOffsetBlendUpTime { get; set; }

		public animSBehaviorConstraintNodeFloorIKLegsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
