using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSlotDataHolder : IScriptable
	{
		[Ordinal(0)]  [RED("ammoData")] public CArray<gameAmmoData> AmmoData { get; set; }
		[Ordinal(1)]  [RED("weapon")] public gameSlotWeaponData Weapon { get; set; }

		public gameSlotDataHolder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
