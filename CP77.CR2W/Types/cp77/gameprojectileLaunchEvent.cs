using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameprojectileLaunchEvent : redEvent
	{
		[Ordinal(0)] [RED("launchParams")] public gameprojectileLaunchParams LaunchParams { get; set; }
		[Ordinal(1)] [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(2)] [RED("weapon")] public wCHandle<gameObject> Weapon { get; set; }
		[Ordinal(3)] [RED("projectileParams")] public gameprojectileWeaponParams ProjectileParams { get; set; }

		public gameprojectileLaunchEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
