using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ThrowableWeaponObject : gameweaponObject
	{
		[Ordinal(62)] 
		[RED("projectileComponent")] 
		public CHandle<gameprojectileComponent> ProjectileComponent
		{
			get => GetPropertyValue<CHandle<gameprojectileComponent>>();
			set => SetPropertyValue<CHandle<gameprojectileComponent>>(value);
		}

		[Ordinal(63)] 
		[RED("weaponOwner")] 
		public CWeakHandle<gameObject> WeaponOwner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}
	}
}
