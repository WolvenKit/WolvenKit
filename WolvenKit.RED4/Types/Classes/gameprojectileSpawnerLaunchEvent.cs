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
			LaunchParams = new();
			ProjectileParams = new() { TargetPosition = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 340282346638528859811704183484516925440.000000F }, SmartGunSpreadOnHitPlane = new(), SmartGunAccuracy = 1.000000F, SmartGunIsProjectileGuided = true, HitPlaneOffset = new(), IgnoreWeaponOwnerCollision = true, RicochetData = new(), Range = -1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
