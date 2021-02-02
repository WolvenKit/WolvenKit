using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCoverObject : gameObject
	{
		[Ordinal(0)]  [RED("coverType")] public CEnum<animCoverState> CoverType { get; set; }
		[Ordinal(1)]  [RED("fovDegrees")] public CFloat FovDegrees { get; set; }
		[Ordinal(2)]  [RED("fovExposureDegrees")] public CFloat FovExposureDegrees { get; set; }
		[Ordinal(3)]  [RED("slotRadius")] public CFloat SlotRadius { get; set; }
		[Ordinal(4)]  [RED("hpMax")] public CFloat HpMax { get; set; }
		[Ordinal(5)]  [RED("isDestructible")] public CBool IsDestructible { get; set; }

		public gameCoverObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
