using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileFollowCurveTrajectoryParams : gameprojectileTrajectoryParams
	{
		private wCHandle<gameObject> _target;
		private CName _componentName;
		private wCHandle<entIPlacedComponent> _targetComponent;
		private Vector4 _targetPosition;
		private CFloat _startVelocity;
		private CFloat _linearTimeRatio;
		private CFloat _interpolationTimeRatio;
		private CFloat _returnTimeMargin;
		private CFloat _bendTimeRatio;
		private CFloat _bendFactor;
		private CFloat _angleInHitPlane;
		private CFloat _angleInVerticalPlane;
		private CBool _shouldRotate;
		private CFloat _halfLeanAngle;
		private CFloat _endLeanAngle;
		private CFloat _angleInterpolationDuration;
		private CFloat _snapRadius;
		private CFloat _accuracy;
		private Vector4 _offset;
		private Vector3 _offsetInPlane;
		private CBool _sendFollowEvent;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CName) CR2WTypeManager.Create("CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetComponent")] 
		public wCHandle<entIPlacedComponent> TargetComponent
		{
			get
			{
				if (_targetComponent == null)
				{
					_targetComponent = (wCHandle<entIPlacedComponent>) CR2WTypeManager.Create("whandle:entIPlacedComponent", "targetComponent", cr2w, this);
				}
				return _targetComponent;
			}
			set
			{
				if (_targetComponent == value)
				{
					return;
				}
				_targetComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get
			{
				if (_startVelocity == null)
				{
					_startVelocity = (CFloat) CR2WTypeManager.Create("Float", "startVelocity", cr2w, this);
				}
				return _startVelocity;
			}
			set
			{
				if (_startVelocity == value)
				{
					return;
				}
				_startVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("linearTimeRatio")] 
		public CFloat LinearTimeRatio
		{
			get
			{
				if (_linearTimeRatio == null)
				{
					_linearTimeRatio = (CFloat) CR2WTypeManager.Create("Float", "linearTimeRatio", cr2w, this);
				}
				return _linearTimeRatio;
			}
			set
			{
				if (_linearTimeRatio == value)
				{
					return;
				}
				_linearTimeRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("interpolationTimeRatio")] 
		public CFloat InterpolationTimeRatio
		{
			get
			{
				if (_interpolationTimeRatio == null)
				{
					_interpolationTimeRatio = (CFloat) CR2WTypeManager.Create("Float", "interpolationTimeRatio", cr2w, this);
				}
				return _interpolationTimeRatio;
			}
			set
			{
				if (_interpolationTimeRatio == value)
				{
					return;
				}
				_interpolationTimeRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("returnTimeMargin")] 
		public CFloat ReturnTimeMargin
		{
			get
			{
				if (_returnTimeMargin == null)
				{
					_returnTimeMargin = (CFloat) CR2WTypeManager.Create("Float", "returnTimeMargin", cr2w, this);
				}
				return _returnTimeMargin;
			}
			set
			{
				if (_returnTimeMargin == value)
				{
					return;
				}
				_returnTimeMargin = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("bendTimeRatio")] 
		public CFloat BendTimeRatio
		{
			get
			{
				if (_bendTimeRatio == null)
				{
					_bendTimeRatio = (CFloat) CR2WTypeManager.Create("Float", "bendTimeRatio", cr2w, this);
				}
				return _bendTimeRatio;
			}
			set
			{
				if (_bendTimeRatio == value)
				{
					return;
				}
				_bendTimeRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("bendFactor")] 
		public CFloat BendFactor
		{
			get
			{
				if (_bendFactor == null)
				{
					_bendFactor = (CFloat) CR2WTypeManager.Create("Float", "bendFactor", cr2w, this);
				}
				return _bendFactor;
			}
			set
			{
				if (_bendFactor == value)
				{
					return;
				}
				_bendFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("angleInHitPlane")] 
		public CFloat AngleInHitPlane
		{
			get
			{
				if (_angleInHitPlane == null)
				{
					_angleInHitPlane = (CFloat) CR2WTypeManager.Create("Float", "angleInHitPlane", cr2w, this);
				}
				return _angleInHitPlane;
			}
			set
			{
				if (_angleInHitPlane == value)
				{
					return;
				}
				_angleInHitPlane = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("angleInVerticalPlane")] 
		public CFloat AngleInVerticalPlane
		{
			get
			{
				if (_angleInVerticalPlane == null)
				{
					_angleInVerticalPlane = (CFloat) CR2WTypeManager.Create("Float", "angleInVerticalPlane", cr2w, this);
				}
				return _angleInVerticalPlane;
			}
			set
			{
				if (_angleInVerticalPlane == value)
				{
					return;
				}
				_angleInVerticalPlane = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("shouldRotate")] 
		public CBool ShouldRotate
		{
			get
			{
				if (_shouldRotate == null)
				{
					_shouldRotate = (CBool) CR2WTypeManager.Create("Bool", "shouldRotate", cr2w, this);
				}
				return _shouldRotate;
			}
			set
			{
				if (_shouldRotate == value)
				{
					return;
				}
				_shouldRotate = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("halfLeanAngle")] 
		public CFloat HalfLeanAngle
		{
			get
			{
				if (_halfLeanAngle == null)
				{
					_halfLeanAngle = (CFloat) CR2WTypeManager.Create("Float", "halfLeanAngle", cr2w, this);
				}
				return _halfLeanAngle;
			}
			set
			{
				if (_halfLeanAngle == value)
				{
					return;
				}
				_halfLeanAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("endLeanAngle")] 
		public CFloat EndLeanAngle
		{
			get
			{
				if (_endLeanAngle == null)
				{
					_endLeanAngle = (CFloat) CR2WTypeManager.Create("Float", "endLeanAngle", cr2w, this);
				}
				return _endLeanAngle;
			}
			set
			{
				if (_endLeanAngle == value)
				{
					return;
				}
				_endLeanAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("angleInterpolationDuration")] 
		public CFloat AngleInterpolationDuration
		{
			get
			{
				if (_angleInterpolationDuration == null)
				{
					_angleInterpolationDuration = (CFloat) CR2WTypeManager.Create("Float", "angleInterpolationDuration", cr2w, this);
				}
				return _angleInterpolationDuration;
			}
			set
			{
				if (_angleInterpolationDuration == value)
				{
					return;
				}
				_angleInterpolationDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("snapRadius")] 
		public CFloat SnapRadius
		{
			get
			{
				if (_snapRadius == null)
				{
					_snapRadius = (CFloat) CR2WTypeManager.Create("Float", "snapRadius", cr2w, this);
				}
				return _snapRadius;
			}
			set
			{
				if (_snapRadius == value)
				{
					return;
				}
				_snapRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("accuracy")] 
		public CFloat Accuracy
		{
			get
			{
				if (_accuracy == null)
				{
					_accuracy = (CFloat) CR2WTypeManager.Create("Float", "accuracy", cr2w, this);
				}
				return _accuracy;
			}
			set
			{
				if (_accuracy == value)
				{
					return;
				}
				_accuracy = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("offset")] 
		public Vector4 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector4) CR2WTypeManager.Create("Vector4", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("offsetInPlane")] 
		public Vector3 OffsetInPlane
		{
			get
			{
				if (_offsetInPlane == null)
				{
					_offsetInPlane = (Vector3) CR2WTypeManager.Create("Vector3", "offsetInPlane", cr2w, this);
				}
				return _offsetInPlane;
			}
			set
			{
				if (_offsetInPlane == value)
				{
					return;
				}
				_offsetInPlane = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("sendFollowEvent")] 
		public CBool SendFollowEvent
		{
			get
			{
				if (_sendFollowEvent == null)
				{
					_sendFollowEvent = (CBool) CR2WTypeManager.Create("Bool", "sendFollowEvent", cr2w, this);
				}
				return _sendFollowEvent;
			}
			set
			{
				if (_sendFollowEvent == value)
				{
					return;
				}
				_sendFollowEvent = value;
				PropertySet(this);
			}
		}

		public gameprojectileFollowCurveTrajectoryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
