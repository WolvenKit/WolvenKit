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
			get
			{
				if (_targetPosition == null)
				{
					_targetPosition = (Vector4) CR2WTypeManager.Create("Vector4", "targetPosition", cr2w, this);
				}
				return _targetPosition;
			}
			set
			{
				if (_targetPosition == value)
				{
					return;
				}
				_targetPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("smartGunSpreadOnHitPlane")] 
		public Vector3 SmartGunSpreadOnHitPlane
		{
			get
			{
				if (_smartGunSpreadOnHitPlane == null)
				{
					_smartGunSpreadOnHitPlane = (Vector3) CR2WTypeManager.Create("Vector3", "smartGunSpreadOnHitPlane", cr2w, this);
				}
				return _smartGunSpreadOnHitPlane;
			}
			set
			{
				if (_smartGunSpreadOnHitPlane == value)
				{
					return;
				}
				_smartGunSpreadOnHitPlane = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("charge")] 
		public CFloat Charge
		{
			get
			{
				if (_charge == null)
				{
					_charge = (CFloat) CR2WTypeManager.Create("Float", "charge", cr2w, this);
				}
				return _charge;
			}
			set
			{
				if (_charge == value)
				{
					return;
				}
				_charge = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("trackedTargetComponent")] 
		public wCHandle<entIPlacedComponent> TrackedTargetComponent
		{
			get
			{
				if (_trackedTargetComponent == null)
				{
					_trackedTargetComponent = (wCHandle<entIPlacedComponent>) CR2WTypeManager.Create("whandle:entIPlacedComponent", "trackedTargetComponent", cr2w, this);
				}
				return _trackedTargetComponent;
			}
			set
			{
				if (_trackedTargetComponent == value)
				{
					return;
				}
				_trackedTargetComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("smartGunAccuracy")] 
		public CFloat SmartGunAccuracy
		{
			get
			{
				if (_smartGunAccuracy == null)
				{
					_smartGunAccuracy = (CFloat) CR2WTypeManager.Create("Float", "smartGunAccuracy", cr2w, this);
				}
				return _smartGunAccuracy;
			}
			set
			{
				if (_smartGunAccuracy == value)
				{
					return;
				}
				_smartGunAccuracy = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("smartGunIsProjectileGuided")] 
		public CBool SmartGunIsProjectileGuided
		{
			get
			{
				if (_smartGunIsProjectileGuided == null)
				{
					_smartGunIsProjectileGuided = (CBool) CR2WTypeManager.Create("Bool", "smartGunIsProjectileGuided", cr2w, this);
				}
				return _smartGunIsProjectileGuided;
			}
			set
			{
				if (_smartGunIsProjectileGuided == value)
				{
					return;
				}
				_smartGunIsProjectileGuided = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("hitPlaneOffset")] 
		public Vector4 HitPlaneOffset
		{
			get
			{
				if (_hitPlaneOffset == null)
				{
					_hitPlaneOffset = (Vector4) CR2WTypeManager.Create("Vector4", "hitPlaneOffset", cr2w, this);
				}
				return _hitPlaneOffset;
			}
			set
			{
				if (_hitPlaneOffset == value)
				{
					return;
				}
				_hitPlaneOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("shootingOffset")] 
		public CFloat ShootingOffset
		{
			get
			{
				if (_shootingOffset == null)
				{
					_shootingOffset = (CFloat) CR2WTypeManager.Create("Float", "shootingOffset", cr2w, this);
				}
				return _shootingOffset;
			}
			set
			{
				if (_shootingOffset == value)
				{
					return;
				}
				_shootingOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ignoreWeaponOwnerCollision")] 
		public CBool IgnoreWeaponOwnerCollision
		{
			get
			{
				if (_ignoreWeaponOwnerCollision == null)
				{
					_ignoreWeaponOwnerCollision = (CBool) CR2WTypeManager.Create("Bool", "ignoreWeaponOwnerCollision", cr2w, this);
				}
				return _ignoreWeaponOwnerCollision;
			}
			set
			{
				if (_ignoreWeaponOwnerCollision == value)
				{
					return;
				}
				_ignoreWeaponOwnerCollision = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("ricochetData")] 
		public gameRicochetData RicochetData
		{
			get
			{
				if (_ricochetData == null)
				{
					_ricochetData = (gameRicochetData) CR2WTypeManager.Create("gameRicochetData", "ricochetData", cr2w, this);
				}
				return _ricochetData;
			}
			set
			{
				if (_ricochetData == value)
				{
					return;
				}
				_ricochetData = value;
				PropertySet(this);
			}
		}

		public gameprojectileWeaponParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
