using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileWeaponParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("smartGunSpreadOnHitPlane")] 
		public Vector3 SmartGunSpreadOnHitPlane
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(2)] 
		[RED("charge")] 
		public CFloat Charge
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("trackedTargetComponent")] 
		public CWeakHandle<entIPlacedComponent> TrackedTargetComponent
		{
			get => GetPropertyValue<CWeakHandle<entIPlacedComponent>>();
			set => SetPropertyValue<CWeakHandle<entIPlacedComponent>>(value);
		}

		[Ordinal(4)] 
		[RED("smartGunAccuracy")] 
		public CFloat SmartGunAccuracy
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("smartGunIsProjectileGuided")] 
		public CBool SmartGunIsProjectileGuided
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("hitPlaneOffset")] 
		public Vector4 HitPlaneOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(7)] 
		[RED("shootingOffset")] 
		public CFloat ShootingOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("ignoreWeaponOwnerCollision")] 
		public CBool IgnoreWeaponOwnerCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("ricochetData")] 
		public gameRicochetData RicochetData
		{
			get => GetPropertyValue<gameRicochetData>();
			set => SetPropertyValue<gameRicochetData>(value);
		}

		[Ordinal(10)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameprojectileWeaponParams()
		{
			TargetPosition = new() { X = 340282346638528859811704183484516925440.000000F, Y = 340282346638528859811704183484516925440.000000F, Z = 340282346638528859811704183484516925440.000000F, W = 340282346638528859811704183484516925440.000000F };
			SmartGunSpreadOnHitPlane = new();
			SmartGunAccuracy = 1.000000F;
			SmartGunIsProjectileGuided = true;
			HitPlaneOffset = new();
			IgnoreWeaponOwnerCollision = true;
			RicochetData = new();
			Range = -1.000000F;
		}
	}
}
