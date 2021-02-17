using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HitIsRarityPrereq : GenericHitPrereq
	{
		[Ordinal(5)] [RED("invert")] public CBool Invert { get; set; }
		[Ordinal(6)] [RED("rarity")] public CEnum<gamedataNPCRarity> Rarity { get; set; }

		public HitIsRarityPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
