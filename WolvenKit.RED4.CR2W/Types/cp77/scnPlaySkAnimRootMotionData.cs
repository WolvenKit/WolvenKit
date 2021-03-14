using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlaySkAnimRootMotionData : CVariable
	{
		private CBool _enabled;
		private CEnum<scnRootMotionAnimPlacementMode> _placementMode;
		private scnMarker _originMarker;
		private Transform _originOffset;
		private CFloat _customBlendInTime;
		private CEnum<scnEasingType> _customBlendInCurve;
		private CBool _removePitchRollRotation;
		private CBool _meshDissolvingEnabled;
		private CBool _vehicleChangePhysicsState;
		private CBool _vehicleEnabledPhysicsOnEnd;
		private CArray<scnAnimationMotionSample> _trajectoryLOD;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("placementMode")] 
		public CEnum<scnRootMotionAnimPlacementMode> PlacementMode
		{
			get
			{
				if (_placementMode == null)
				{
					_placementMode = (CEnum<scnRootMotionAnimPlacementMode>) CR2WTypeManager.Create("scnRootMotionAnimPlacementMode", "placementMode", cr2w, this);
				}
				return _placementMode;
			}
			set
			{
				if (_placementMode == value)
				{
					return;
				}
				_placementMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("originMarker")] 
		public scnMarker OriginMarker
		{
			get
			{
				if (_originMarker == null)
				{
					_originMarker = (scnMarker) CR2WTypeManager.Create("scnMarker", "originMarker", cr2w, this);
				}
				return _originMarker;
			}
			set
			{
				if (_originMarker == value)
				{
					return;
				}
				_originMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("originOffset")] 
		public Transform OriginOffset
		{
			get
			{
				if (_originOffset == null)
				{
					_originOffset = (Transform) CR2WTypeManager.Create("Transform", "originOffset", cr2w, this);
				}
				return _originOffset;
			}
			set
			{
				if (_originOffset == value)
				{
					return;
				}
				_originOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("customBlendInTime")] 
		public CFloat CustomBlendInTime
		{
			get
			{
				if (_customBlendInTime == null)
				{
					_customBlendInTime = (CFloat) CR2WTypeManager.Create("Float", "customBlendInTime", cr2w, this);
				}
				return _customBlendInTime;
			}
			set
			{
				if (_customBlendInTime == value)
				{
					return;
				}
				_customBlendInTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("customBlendInCurve")] 
		public CEnum<scnEasingType> CustomBlendInCurve
		{
			get
			{
				if (_customBlendInCurve == null)
				{
					_customBlendInCurve = (CEnum<scnEasingType>) CR2WTypeManager.Create("scnEasingType", "customBlendInCurve", cr2w, this);
				}
				return _customBlendInCurve;
			}
			set
			{
				if (_customBlendInCurve == value)
				{
					return;
				}
				_customBlendInCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("removePitchRollRotation")] 
		public CBool RemovePitchRollRotation
		{
			get
			{
				if (_removePitchRollRotation == null)
				{
					_removePitchRollRotation = (CBool) CR2WTypeManager.Create("Bool", "removePitchRollRotation", cr2w, this);
				}
				return _removePitchRollRotation;
			}
			set
			{
				if (_removePitchRollRotation == value)
				{
					return;
				}
				_removePitchRollRotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("meshDissolvingEnabled")] 
		public CBool MeshDissolvingEnabled
		{
			get
			{
				if (_meshDissolvingEnabled == null)
				{
					_meshDissolvingEnabled = (CBool) CR2WTypeManager.Create("Bool", "meshDissolvingEnabled", cr2w, this);
				}
				return _meshDissolvingEnabled;
			}
			set
			{
				if (_meshDissolvingEnabled == value)
				{
					return;
				}
				_meshDissolvingEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("vehicleChangePhysicsState")] 
		public CBool VehicleChangePhysicsState
		{
			get
			{
				if (_vehicleChangePhysicsState == null)
				{
					_vehicleChangePhysicsState = (CBool) CR2WTypeManager.Create("Bool", "vehicleChangePhysicsState", cr2w, this);
				}
				return _vehicleChangePhysicsState;
			}
			set
			{
				if (_vehicleChangePhysicsState == value)
				{
					return;
				}
				_vehicleChangePhysicsState = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("vehicleEnabledPhysicsOnEnd")] 
		public CBool VehicleEnabledPhysicsOnEnd
		{
			get
			{
				if (_vehicleEnabledPhysicsOnEnd == null)
				{
					_vehicleEnabledPhysicsOnEnd = (CBool) CR2WTypeManager.Create("Bool", "vehicleEnabledPhysicsOnEnd", cr2w, this);
				}
				return _vehicleEnabledPhysicsOnEnd;
			}
			set
			{
				if (_vehicleEnabledPhysicsOnEnd == value)
				{
					return;
				}
				_vehicleEnabledPhysicsOnEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("trajectoryLOD")] 
		public CArray<scnAnimationMotionSample> TrajectoryLOD
		{
			get
			{
				if (_trajectoryLOD == null)
				{
					_trajectoryLOD = (CArray<scnAnimationMotionSample>) CR2WTypeManager.Create("array:scnAnimationMotionSample", "trajectoryLOD", cr2w, this);
				}
				return _trajectoryLOD;
			}
			set
			{
				if (_trajectoryLOD == value)
				{
					return;
				}
				_trajectoryLOD = value;
				PropertySet(this);
			}
		}

		public scnPlaySkAnimRootMotionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
