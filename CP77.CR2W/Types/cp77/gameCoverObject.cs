using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameCoverObject : gameObject
	{
		[Ordinal(0)]  [RED("coverType")] public CEnum<animCoverState> CoverType { get; set; }
		[Ordinal(1)]  [RED("fovDegrees")] public CFloat FovDegrees { get; set; }
		[Ordinal(2)]  [RED("fovExposureDegrees")] public CFloat FovExposureDegrees { get; set; }
		[Ordinal(3)]  [RED("hpMax")] public CFloat HpMax { get; set; }
		[Ordinal(4)]  [RED("isDestructible")] public CBool IsDestructible { get; set; }
		[Ordinal(5)]  [RED("slotRadius")] public CFloat SlotRadius { get; set; }

		public gameCoverObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
