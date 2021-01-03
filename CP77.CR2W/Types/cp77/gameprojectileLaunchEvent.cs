using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameprojectileLaunchEvent : redEvent
	{
		[Ordinal(0)]  [RED("launchParams")] public gameprojectileLaunchParams LaunchParams { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(2)]  [RED("projectileParams")] public gameprojectileWeaponParams ProjectileParams { get; set; }
		[Ordinal(3)]  [RED("weapon")] public wCHandle<gameObject> Weapon { get; set; }

		public gameprojectileLaunchEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
