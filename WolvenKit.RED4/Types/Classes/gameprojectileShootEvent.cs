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
			LocalToWorld = new CMatrix();
			StartPoint = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue };
			StartVelocity = new Vector4();
			WeaponVelocity = new Vector4();
			Params = new gameprojectileWeaponParams { TargetPosition = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue }, SmartGunSpreadOnHitPlane = new Vector3(), SmartGunAccuracy = 1.000000F, SmartGunIsProjectileGuided = true, HitPlaneOffset = new Vector4(), IgnoreWeaponOwnerCollision = true, RicochetData = new gameRicochetData(), Range = -1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
