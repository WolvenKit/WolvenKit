using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioMeleeAttackSettings : CVariable
	{
		[Ordinal(0)]  [RED("criticalHitEvent")] public CName CriticalHitEvent { get; set; }
		[Ordinal(1)]  [RED("hitEvent")] public CName HitEvent { get; set; }
		[Ordinal(2)]  [RED("killingHitEvent")] public CName KillingHitEvent { get; set; }
		[Ordinal(3)]  [RED("penetratingHitEvent")] public CName PenetratingHitEvent { get; set; }

		public audioMeleeAttackSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
