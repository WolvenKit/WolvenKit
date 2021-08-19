using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThrowableWeaponObject : gameweaponObject
	{
		private CHandle<gameprojectileComponent> _projectileComponent;
		private wCHandle<gameObject> _weaponOwner;

		[Ordinal(62)] 
		[RED("projectileComponent")] 
		public CHandle<gameprojectileComponent> ProjectileComponent
		{
			get => GetProperty(ref _projectileComponent);
			set => SetProperty(ref _projectileComponent, value);
		}

		[Ordinal(63)] 
		[RED("weaponOwner")] 
		public wCHandle<gameObject> WeaponOwner
		{
			get => GetProperty(ref _weaponOwner);
			set => SetProperty(ref _weaponOwner, value);
		}

		public ThrowableWeaponObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
