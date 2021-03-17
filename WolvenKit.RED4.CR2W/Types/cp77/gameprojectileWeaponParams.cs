using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileWeaponParams : CVariable
	{
		private Vector4 _targetPosition;
		private Vector3 _smartGunSpreadOnHitPlane;
		private CFloat _charge;
		private wCHandle<entIPlacedComponent> _trackedTargetComponent;
		private CFloat _smartGunAccuracy;
		private CBool _smartGunIsProjectileGuided;
		private Vector4 _hitPlaneOffset;
		private CFloat _shootingOffset;
		private CBool _ignoreWeaponOwnerCollision;
		private gameRicochetData _ricochetData;

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
		public wCHandle<entIPlacedComponent> TrackedTargetComponent
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

		public gameprojectileWeaponParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
