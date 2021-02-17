using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioBulletImpactSettings : audioEntitySettings
	{
		[Ordinal(6)] [RED("lowImpactSound")] public CName LowImpactSound { get; set; }
		[Ordinal(7)] [RED("medImpactSound")] public CName MedImpactSound { get; set; }
		[Ordinal(8)] [RED("hiImpactSound")] public CName HiImpactSound { get; set; }
		[Ordinal(9)] [RED("critImpactSound")] public CName CritImpactSound { get; set; }
		[Ordinal(10)] [RED("npcImpactSound")] public CName NpcImpactSound { get; set; }
		[Ordinal(11)] [RED("mediumDamageDistance")] public CFloat MediumDamageDistance { get; set; }
		[Ordinal(12)] [RED("highDamageDistance")] public CFloat HighDamageDistance { get; set; }

		public audioBulletImpactSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
