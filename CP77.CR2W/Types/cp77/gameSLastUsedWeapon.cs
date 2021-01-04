using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSLastUsedWeapon : CVariable
	{
		[Ordinal(0)]  [RED("lastUsedHeavy")] public gameItemID LastUsedHeavy { get; set; }
		[Ordinal(1)]  [RED("lastUsedMelee")] public gameItemID LastUsedMelee { get; set; }
		[Ordinal(2)]  [RED("lastUsedRanged")] public gameItemID LastUsedRanged { get; set; }
		[Ordinal(3)]  [RED("lastUsedWeapon")] public gameItemID LastUsedWeapon { get; set; }

		public gameSLastUsedWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
