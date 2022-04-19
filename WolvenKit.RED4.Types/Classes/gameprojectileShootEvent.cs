using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileShootEvent : gameprojectileSetUpEvent
	{
		[Ordinal(4)] 
		[RED("localToWorld")] 
		public CMatrix LocalToWorld
		{
			get => GetPropertyValue<CMatrix>();
			set => SetPropertyValue<CMatrix>(value);
		}

		[Ordinal(5)] 
		[RED("startPoint")] 
		public Vector4 StartPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("startVelocity")] 
		public Vector4 StartVelocity
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(7)] 
		[RED("weaponVelocity")] 
		public Vector4 WeaponVelocity
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(8)] 
		[RED("params")] 
		public gameprojectileWeaponParams Params
		{
			get => GetPropertyValue<gameprojectileWeaponParams>();
			set => SetPropertyValue<gameprojectileWeaponParams>(value);
		}

		public gameprojectileShootEvent()
		{
			LocalToWorld = new();
			StartPoint = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 340282346638528859811704183484516925440.000000F };
			StartVelocity = new();
			WeaponVelocity = new();
			Params = new() { TargetPosition = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 340282346638528859811704183484516925440.000000F }, SmartGunSpreadOnHitPlane = new(), SmartGunAccuracy = 1.000000F, SmartGunIsProjectileGuided = true, HitPlaneOffset = new(), IgnoreWeaponOwnerCollision = true, RicochetData = new(), Range = -1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
