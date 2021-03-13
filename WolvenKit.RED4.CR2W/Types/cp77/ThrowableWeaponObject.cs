using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThrowableWeaponObject : gameweaponObject
	{
		[Ordinal(57)] [RED("projectileComponent")] public CHandle<gameprojectileComponent> ProjectileComponent { get; set; }
		[Ordinal(58)] [RED("weaponOwner")] public wCHandle<gameObject> WeaponOwner { get; set; }

		public ThrowableWeaponObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
