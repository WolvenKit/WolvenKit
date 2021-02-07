using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioBulletImpactSettings : audioEntitySettings
	{
		[Ordinal(0)]  [RED("lowImpactSound")] public CName LowImpactSound { get; set; }
		[Ordinal(1)]  [RED("medImpactSound")] public CName MedImpactSound { get; set; }
		[Ordinal(2)]  [RED("hiImpactSound")] public CName HiImpactSound { get; set; }
		[Ordinal(3)]  [RED("critImpactSound")] public CName CritImpactSound { get; set; }
		[Ordinal(4)]  [RED("npcImpactSound")] public CName NpcImpactSound { get; set; }
		[Ordinal(5)]  [RED("mediumDamageDistance")] public CFloat MediumDamageDistance { get; set; }
		[Ordinal(6)]  [RED("highDamageDistance")] public CFloat HighDamageDistance { get; set; }

		public audioBulletImpactSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
