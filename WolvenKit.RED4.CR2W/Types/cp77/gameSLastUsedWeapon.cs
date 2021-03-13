using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSLastUsedWeapon : CVariable
	{
		[Ordinal(0)] [RED("lastUsedWeapon")] public gameItemID LastUsedWeapon { get; set; }
		[Ordinal(1)] [RED("lastUsedRanged")] public gameItemID LastUsedRanged { get; set; }
		[Ordinal(2)] [RED("lastUsedMelee")] public gameItemID LastUsedMelee { get; set; }
		[Ordinal(3)] [RED("lastUsedHeavy")] public gameItemID LastUsedHeavy { get; set; }

		public gameSLastUsedWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
