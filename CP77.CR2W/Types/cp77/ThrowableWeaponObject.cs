using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ThrowableWeaponObject : gameweaponObject
	{
		[Ordinal(0)]  [RED("projectileComponent")] public CHandle<gameprojectileComponent> ProjectileComponent { get; set; }
		[Ordinal(1)]  [RED("weaponOwner")] public wCHandle<gameObject> WeaponOwner { get; set; }

		public ThrowableWeaponObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
