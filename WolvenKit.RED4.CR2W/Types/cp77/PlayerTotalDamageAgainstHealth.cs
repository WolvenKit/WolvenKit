using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerTotalDamageAgainstHealth : CVariable
	{
		[Ordinal(0)] [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(1)] [RED("totalDamage")] public CFloat TotalDamage { get; set; }
		[Ordinal(2)] [RED("targetHealth")] public CFloat TargetHealth { get; set; }

		public PlayerTotalDamageAgainstHealth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
