using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WeaponChargeStatListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)]  [RED("weapon")] public wCHandle<gameweaponObject> Weapon { get; set; }

		public WeaponChargeStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
