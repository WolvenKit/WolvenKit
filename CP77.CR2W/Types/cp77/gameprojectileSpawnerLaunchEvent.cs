using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameprojectileSpawnerLaunchEvent : redEvent
	{
		[Ordinal(0)]  [RED("launchParams")] public gameprojectileLaunchParams LaunchParams { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(2)]  [RED("projectileParams")] public gameprojectileWeaponParams ProjectileParams { get; set; }
		[Ordinal(3)]  [RED("templateName")] public CName TemplateName { get; set; }

		public gameprojectileSpawnerLaunchEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
