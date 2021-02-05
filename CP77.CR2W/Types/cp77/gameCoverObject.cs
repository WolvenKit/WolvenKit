using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCoverObject : gameObject
	{
		[Ordinal(31)]  [RED("coverType")] public CEnum<animCoverState> CoverType { get; set; }
		[Ordinal(32)]  [RED("slotRadius")] public CFloat SlotRadius { get; set; }
		[Ordinal(33)]  [RED("hpMax")] public CFloat HpMax { get; set; }
		[Ordinal(34)]  [RED("isDestructible")] public CBool IsDestructible { get; set; }
		[Ordinal(35)]  [RED("fovDegrees")] public CFloat FovDegrees { get; set; }
		[Ordinal(36)]  [RED("fovExposureDegrees")] public CFloat FovExposureDegrees { get; set; }

		public gameCoverObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
