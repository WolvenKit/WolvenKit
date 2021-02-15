using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WeaponChargeStatListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }

		public WeaponChargeStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
