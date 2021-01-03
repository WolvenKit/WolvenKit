using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioBulletImpactSettings : audioEntitySettings
	{
		[Ordinal(0)]  [RED("critImpactSound")] public CName CritImpactSound { get; set; }
		[Ordinal(1)]  [RED("hiImpactSound")] public CName HiImpactSound { get; set; }
		[Ordinal(2)]  [RED("highDamageDistance")] public CFloat HighDamageDistance { get; set; }
		[Ordinal(3)]  [RED("lowImpactSound")] public CName LowImpactSound { get; set; }
		[Ordinal(4)]  [RED("medImpactSound")] public CName MedImpactSound { get; set; }
		[Ordinal(5)]  [RED("mediumDamageDistance")] public CFloat MediumDamageDistance { get; set; }
		[Ordinal(6)]  [RED("npcImpactSound")] public CName NpcImpactSound { get; set; }

		public audioBulletImpactSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
