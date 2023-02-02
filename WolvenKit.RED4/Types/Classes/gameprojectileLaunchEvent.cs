using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileLaunchEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("launchParams")] 
		public gameprojectileLaunchParams LaunchParams
		{
			get => GetPropertyValue<gameprojectileLaunchParams>();
			set => SetPropertyValue<gameprojectileLaunchParams>(value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(2)] 
		[RED("weapon")] 
		public CWeakHandle<gameObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("projectileParams")] 
		public gameprojectileWeaponParams ProjectileParams
		{
			get => GetPropertyValue<gameprojectileWeaponParams>();
			set => SetPropertyValue<gameprojectileWeaponParams>(value);
		}

		public gameprojectileLaunchEvent()
		{
			LaunchParams = new();
			ProjectileParams = new() { TargetPosition = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 340282346638528859811704183484516925440.000000F }, SmartGunSpreadOnHitPlane = new(), SmartGunAccuracy = 1.000000F, SmartGunIsProjectileGuided = true, HitPlaneOffset = new(), IgnoreWeaponOwnerCollision = true, RicochetData = new(), Range = -1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
