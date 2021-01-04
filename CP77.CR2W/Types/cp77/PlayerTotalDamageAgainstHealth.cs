using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerTotalDamageAgainstHealth : CVariable
	{
		[Ordinal(0)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(1)]  [RED("targetHealth")] public CFloat TargetHealth { get; set; }
		[Ordinal(2)]  [RED("totalDamage")] public CFloat TotalDamage { get; set; }

		public PlayerTotalDamageAgainstHealth(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
