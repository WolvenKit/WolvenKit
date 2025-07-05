using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ThrowableWeaponObject : gameweaponObject
	{
		[Ordinal(66)] 
		[RED("projectileComponent")] 
		public CHandle<gameprojectileComponent> ProjectileComponent
		{
			get => GetPropertyValue<CHandle<gameprojectileComponent>>();
			set => SetPropertyValue<CHandle<gameprojectileComponent>>(value);
		}

		[Ordinal(67)] 
		[RED("weaponOwner")] 
		public CWeakHandle<gameObject> WeaponOwner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public ThrowableWeaponObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
