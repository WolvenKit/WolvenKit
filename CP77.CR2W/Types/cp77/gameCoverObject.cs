using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCoverObject : gameObject
	{
		[Ordinal(40)] [RED("coverType")] public CEnum<animCoverState> CoverType { get; set; }
		[Ordinal(41)] [RED("slotRadius")] public CFloat SlotRadius { get; set; }
		[Ordinal(42)] [RED("hpMax")] public CFloat HpMax { get; set; }
		[Ordinal(43)] [RED("isDestructible")] public CBool IsDestructible { get; set; }
		[Ordinal(44)] [RED("fovDegrees")] public CFloat FovDegrees { get; set; }
		[Ordinal(45)] [RED("fovExposureDegrees")] public CFloat FovExposureDegrees { get; set; }

		public gameCoverObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
