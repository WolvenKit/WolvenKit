using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameprojectileWeaponParams : RedBaseClass
	{
		private Vector4 _targetPosition;
		private Vector3 _smartGunSpreadOnHitPlane;
		private CFloat _charge;
		private CWeakHandle<entIPlacedComponent> _trackedTargetComponent;
		private CFloat _smartGunAccuracy;
		private CBool _smartGunIsProjectileGuided;
		private Vector4 _hitPlaneOffset;
		private CFloat _shootingOffset;
		private CBool _ignoreWeaponOwnerCollision;
		private gameRicochetData _ricochetData;
		private CFloat _range;

		[Ordinal(0)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(1)] 
		[RED("smartGunSpreadOnHitPlane")] 
		public Vector3 SmartGunSpreadOnHitPlane
		{
			get => GetProperty(ref _smartGunSpreadOnHitPlane);
			set => SetProperty(ref _smartGunSpreadOnHitPlane, value);
		}

		[Ordinal(2)] 
		[RED("charge")] 
		public CFloat Charge
		{
			get => GetProperty(ref _charge);
			set => SetProperty(ref _charge, value);
		}

		[Ordinal(3)] 
		[RED("trackedTargetComponent")] 
		public CWeakHandle<entIPlacedComponent> TrackedTargetComponent
		{
			get => GetProperty(ref _trackedTargetComponent);
			set => SetProperty(ref _trackedTargetComponent, value);
		}

		[Ordinal(4)] 
		[RED("smartGunAccuracy")] 
		public CFloat SmartGunAccuracy
		{
			get => GetProperty(ref _smartGunAccuracy);
			set => SetProperty(ref _smartGunAccuracy, value);
		}

		[Ordinal(5)] 
		[RED("smartGunIsProjectileGuided")] 
		public CBool SmartGunIsProjectileGuided
		{
			get => GetProperty(ref _smartGunIsProjectileGuided);
			set => SetProperty(ref _smartGunIsProjectileGuided, value);
		}

		[Ordinal(6)] 
		[RED("hitPlaneOffset")] 
		public Vector4 HitPlaneOffset
		{
			get => GetProperty(ref _hitPlaneOffset);
			set => SetProperty(ref _hitPlaneOffset, value);
		}

		[Ordinal(7)] 
		[RED("shootingOffset")] 
		public CFloat ShootingOffset
		{
			get => GetProperty(ref _shootingOffset);
			set => SetProperty(ref _shootingOffset, value);
		}

		[Ordinal(8)] 
		[RED("ignoreWeaponOwnerCollision")] 
		public CBool IgnoreWeaponOwnerCollision
		{
			get => GetProperty(ref _ignoreWeaponOwnerCollision);
			set => SetProperty(ref _ignoreWeaponOwnerCollision, value);
		}

		[Ordinal(9)] 
		[RED("ricochetData")] 
		public gameRicochetData RicochetData
		{
			get => GetProperty(ref _ricochetData);
			set => SetProperty(ref _ricochetData, value);
		}

		[Ordinal(10)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		public gameprojectileWeaponParams()
		{
			_smartGunAccuracy = 1.000000F;
			_smartGunIsProjectileGuided = true;
			_ignoreWeaponOwnerCollision = true;
			_range = -1.000000F;
		}
	}
}
