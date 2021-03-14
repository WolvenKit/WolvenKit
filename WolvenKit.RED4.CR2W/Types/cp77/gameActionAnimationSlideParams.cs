using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionAnimationSlideParams : CVariable
	{
		private CFloat _distance;
		private CFloat _directionAngle;
		private CFloat _finalRotationAngle;
		private CFloat _offsetToTarget;
		private CFloat _offsetAroundTarget;
		private CBool _slideToTarget;
		private CFloat _duration;
		private CFloat _positionSpeed;
		private CFloat _rotationSpeed;
		private CFloat _maxSlidePositionDistance;
		private CFloat _maxSlideRotationAngle;
		private CFloat _slideStartDelay;
		private CBool _usePositionSlide;
		private CBool _useRotationSlide;
		private CFloat _maxTargetVelocity;
		private CFloat _zAlignmentThreshold;

		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get
			{
				if (_distance == null)
				{
					_distance = (CFloat) CR2WTypeManager.Create("Float", "distance", cr2w, this);
				}
				return _distance;
			}
			set
			{
				if (_distance == value)
				{
					return;
				}
				_distance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("directionAngle")] 
		public CFloat DirectionAngle
		{
			get
			{
				if (_directionAngle == null)
				{
					_directionAngle = (CFloat) CR2WTypeManager.Create("Float", "directionAngle", cr2w, this);
				}
				return _directionAngle;
			}
			set
			{
				if (_directionAngle == value)
				{
					return;
				}
				_directionAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("finalRotationAngle")] 
		public CFloat FinalRotationAngle
		{
			get
			{
				if (_finalRotationAngle == null)
				{
					_finalRotationAngle = (CFloat) CR2WTypeManager.Create("Float", "finalRotationAngle", cr2w, this);
				}
				return _finalRotationAngle;
			}
			set
			{
				if (_finalRotationAngle == value)
				{
					return;
				}
				_finalRotationAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("offsetToTarget")] 
		public CFloat OffsetToTarget
		{
			get
			{
				if (_offsetToTarget == null)
				{
					_offsetToTarget = (CFloat) CR2WTypeManager.Create("Float", "offsetToTarget", cr2w, this);
				}
				return _offsetToTarget;
			}
			set
			{
				if (_offsetToTarget == value)
				{
					return;
				}
				_offsetToTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("offsetAroundTarget")] 
		public CFloat OffsetAroundTarget
		{
			get
			{
				if (_offsetAroundTarget == null)
				{
					_offsetAroundTarget = (CFloat) CR2WTypeManager.Create("Float", "offsetAroundTarget", cr2w, this);
				}
				return _offsetAroundTarget;
			}
			set
			{
				if (_offsetAroundTarget == value)
				{
					return;
				}
				_offsetAroundTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("slideToTarget")] 
		public CBool SlideToTarget
		{
			get
			{
				if (_slideToTarget == null)
				{
					_slideToTarget = (CBool) CR2WTypeManager.Create("Bool", "slideToTarget", cr2w, this);
				}
				return _slideToTarget;
			}
			set
			{
				if (_slideToTarget == value)
				{
					return;
				}
				_slideToTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("positionSpeed")] 
		public CFloat PositionSpeed
		{
			get
			{
				if (_positionSpeed == null)
				{
					_positionSpeed = (CFloat) CR2WTypeManager.Create("Float", "positionSpeed", cr2w, this);
				}
				return _positionSpeed;
			}
			set
			{
				if (_positionSpeed == value)
				{
					return;
				}
				_positionSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("rotationSpeed")] 
		public CFloat RotationSpeed
		{
			get
			{
				if (_rotationSpeed == null)
				{
					_rotationSpeed = (CFloat) CR2WTypeManager.Create("Float", "rotationSpeed", cr2w, this);
				}
				return _rotationSpeed;
			}
			set
			{
				if (_rotationSpeed == value)
				{
					return;
				}
				_rotationSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("maxSlidePositionDistance")] 
		public CFloat MaxSlidePositionDistance
		{
			get
			{
				if (_maxSlidePositionDistance == null)
				{
					_maxSlidePositionDistance = (CFloat) CR2WTypeManager.Create("Float", "maxSlidePositionDistance", cr2w, this);
				}
				return _maxSlidePositionDistance;
			}
			set
			{
				if (_maxSlidePositionDistance == value)
				{
					return;
				}
				_maxSlidePositionDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("maxSlideRotationAngle")] 
		public CFloat MaxSlideRotationAngle
		{
			get
			{
				if (_maxSlideRotationAngle == null)
				{
					_maxSlideRotationAngle = (CFloat) CR2WTypeManager.Create("Float", "maxSlideRotationAngle", cr2w, this);
				}
				return _maxSlideRotationAngle;
			}
			set
			{
				if (_maxSlideRotationAngle == value)
				{
					return;
				}
				_maxSlideRotationAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("slideStartDelay")] 
		public CFloat SlideStartDelay
		{
			get
			{
				if (_slideStartDelay == null)
				{
					_slideStartDelay = (CFloat) CR2WTypeManager.Create("Float", "slideStartDelay", cr2w, this);
				}
				return _slideStartDelay;
			}
			set
			{
				if (_slideStartDelay == value)
				{
					return;
				}
				_slideStartDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("usePositionSlide")] 
		public CBool UsePositionSlide
		{
			get
			{
				if (_usePositionSlide == null)
				{
					_usePositionSlide = (CBool) CR2WTypeManager.Create("Bool", "usePositionSlide", cr2w, this);
				}
				return _usePositionSlide;
			}
			set
			{
				if (_usePositionSlide == value)
				{
					return;
				}
				_usePositionSlide = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("useRotationSlide")] 
		public CBool UseRotationSlide
		{
			get
			{
				if (_useRotationSlide == null)
				{
					_useRotationSlide = (CBool) CR2WTypeManager.Create("Bool", "useRotationSlide", cr2w, this);
				}
				return _useRotationSlide;
			}
			set
			{
				if (_useRotationSlide == value)
				{
					return;
				}
				_useRotationSlide = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("maxTargetVelocity")] 
		public CFloat MaxTargetVelocity
		{
			get
			{
				if (_maxTargetVelocity == null)
				{
					_maxTargetVelocity = (CFloat) CR2WTypeManager.Create("Float", "maxTargetVelocity", cr2w, this);
				}
				return _maxTargetVelocity;
			}
			set
			{
				if (_maxTargetVelocity == value)
				{
					return;
				}
				_maxTargetVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("zAlignmentThreshold")] 
		public CFloat ZAlignmentThreshold
		{
			get
			{
				if (_zAlignmentThreshold == null)
				{
					_zAlignmentThreshold = (CFloat) CR2WTypeManager.Create("Float", "zAlignmentThreshold", cr2w, this);
				}
				return _zAlignmentThreshold;
			}
			set
			{
				if (_zAlignmentThreshold == value)
				{
					return;
				}
				_zAlignmentThreshold = value;
				PropertySet(this);
			}
		}

		public gameActionAnimationSlideParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
