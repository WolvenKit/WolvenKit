using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ThrowableWeaponObject : gameweaponObject
	{
		private CHandle<gameprojectileComponent> _projectileComponent;
		private CWeakHandle<gameObject> _weaponOwner;

		[Ordinal(62)] 
		[RED("projectileComponent")] 
		public CHandle<gameprojectileComponent> ProjectileComponent
		{
			get => GetProperty(ref _projectileComponent);
			set => SetProperty(ref _projectileComponent, value);
		}

		[Ordinal(63)] 
		[RED("weaponOwner")] 
		public CWeakHandle<gameObject> WeaponOwner
		{
			get => GetProperty(ref _weaponOwner);
			set => SetProperty(ref _weaponOwner, value);
		}
	}
}
