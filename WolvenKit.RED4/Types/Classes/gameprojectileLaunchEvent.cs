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
			LaunchParams = new gameprojectileLaunchParams();
			ProjectileParams = new gameprojectileWeaponParams { TargetPosition = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue }, SmartGunSpreadOnHitPlane = new Vector3(), SmartGunAccuracy = 1.000000F, SmartGunIsProjectileGuided = true, HitPlaneOffset = new Vector4(), IgnoreWeaponOwnerCollision = true, RicochetData = new gameRicochetData(), Range = -1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
