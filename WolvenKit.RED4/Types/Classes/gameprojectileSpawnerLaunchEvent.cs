using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileSpawnerLaunchEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("launchParams")] 
		public gameprojectileLaunchParams LaunchParams
		{
			get => GetPropertyValue<gameprojectileLaunchParams>();
			set => SetPropertyValue<gameprojectileLaunchParams>(value);
		}

		[Ordinal(1)] 
		[RED("templateName")] 
		public CName TemplateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(4)] 
		[RED("projectileParams")] 
		public gameprojectileWeaponParams ProjectileParams
		{
			get => GetPropertyValue<gameprojectileWeaponParams>();
			set => SetPropertyValue<gameprojectileWeaponParams>(value);
		}

		public gameprojectileSpawnerLaunchEvent()
		{
			LaunchParams = new gameprojectileLaunchParams();
			ProjectileParams = new gameprojectileWeaponParams { TargetPosition = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue }, SmartGunSpreadOnHitPlane = new Vector3(), SmartGunAccuracy = 1.000000F, SmartGunIsProjectileGuided = true, HitPlaneOffset = new Vector4(), IgnoreWeaponOwnerCollision = true, RicochetData = new gameRicochetData(), Range = -1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
