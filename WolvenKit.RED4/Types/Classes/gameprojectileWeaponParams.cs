using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
		[RED("ignoreMountedVehicleCollision")] 
		public CBool IgnoreMountedVehicleCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("ricochetData")] 
		public gameRicochetData RicochetData
		{
			get => GetPropertyValue<gameRicochetData>();
			set => SetPropertyValue<gameRicochetData>(value);
		}

		[Ordinal(11)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameprojectileWeaponParams()
		{
			TargetPosition = new Vector4 { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue, W = float.MaxValue };
			SmartGunSpreadOnHitPlane = new Vector3();
			SmartGunAccuracy = 1.000000F;
			SmartGunIsProjectileGuided = true;
			HitPlaneOffset = new Vector4();
			IgnoreWeaponOwnerCollision = true;
			RicochetData = new gameRicochetData();
			Range = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
