using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Crowd : animAnimFeature
	{
		private CInt32 _stopType;
		private CInt32 _speedType;
		private CInt32 _speedOverrideType;
		private CInt32 _bumpDirection;
		private CInt32 _threatSource;
		private CInt32 _locomotionState;
		private CInt32 _bumpSourceLocation;
		private CFloat _lookAtAngle;
		private CInt32 _fearStage;
		private CInt32 _startType;
		private CFloat _startDirectionAngle;
		private CFloat _animTime;
		private CBool _isBlocked;
		private CInt32 _bumpType;
		private CInt32 _fleeType;

		[Ordinal(0)] 
		[RED("stopType")] 
		public CInt32 StopType
		{
			get
			{
				if (_stopType == null)
				{
					_stopType = (CInt32) CR2WTypeManager.Create("Int32", "stopType", cr2w, this);
				}
				return _stopType;
			}
			set
			{
				if (_stopType == value)
				{
					return;
				}
				_stopType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("speedType")] 
		public CInt32 SpeedType
		{
			get
			{
				if (_speedType == null)
				{
					_speedType = (CInt32) CR2WTypeManager.Create("Int32", "speedType", cr2w, this);
				}
				return _speedType;
			}
			set
			{
				if (_speedType == value)
				{
					return;
				}
				_speedType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("speedOverrideType")] 
		public CInt32 SpeedOverrideType
		{
			get
			{
				if (_speedOverrideType == null)
				{
					_speedOverrideType = (CInt32) CR2WTypeManager.Create("Int32", "speedOverrideType", cr2w, this);
				}
				return _speedOverrideType;
			}
			set
			{
				if (_speedOverrideType == value)
				{
					return;
				}
				_speedOverrideType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("bumpDirection")] 
		public CInt32 BumpDirection
		{
			get
			{
				if (_bumpDirection == null)
				{
					_bumpDirection = (CInt32) CR2WTypeManager.Create("Int32", "bumpDirection", cr2w, this);
				}
				return _bumpDirection;
			}
			set
			{
				if (_bumpDirection == value)
				{
					return;
				}
				_bumpDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("threatSource")] 
		public CInt32 ThreatSource
		{
			get
			{
				if (_threatSource == null)
				{
					_threatSource = (CInt32) CR2WTypeManager.Create("Int32", "threatSource", cr2w, this);
				}
				return _threatSource;
			}
			set
			{
				if (_threatSource == value)
				{
					return;
				}
				_threatSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("locomotionState")] 
		public CInt32 LocomotionState
		{
			get
			{
				if (_locomotionState == null)
				{
					_locomotionState = (CInt32) CR2WTypeManager.Create("Int32", "locomotionState", cr2w, this);
				}
				return _locomotionState;
			}
			set
			{
				if (_locomotionState == value)
				{
					return;
				}
				_locomotionState = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("bumpSourceLocation")] 
		public CInt32 BumpSourceLocation
		{
			get
			{
				if (_bumpSourceLocation == null)
				{
					_bumpSourceLocation = (CInt32) CR2WTypeManager.Create("Int32", "bumpSourceLocation", cr2w, this);
				}
				return _bumpSourceLocation;
			}
			set
			{
				if (_bumpSourceLocation == value)
				{
					return;
				}
				_bumpSourceLocation = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("lookAtAngle")] 
		public CFloat LookAtAngle
		{
			get
			{
				if (_lookAtAngle == null)
				{
					_lookAtAngle = (CFloat) CR2WTypeManager.Create("Float", "lookAtAngle", cr2w, this);
				}
				return _lookAtAngle;
			}
			set
			{
				if (_lookAtAngle == value)
				{
					return;
				}
				_lookAtAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("fearStage")] 
		public CInt32 FearStage
		{
			get
			{
				if (_fearStage == null)
				{
					_fearStage = (CInt32) CR2WTypeManager.Create("Int32", "fearStage", cr2w, this);
				}
				return _fearStage;
			}
			set
			{
				if (_fearStage == value)
				{
					return;
				}
				_fearStage = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("startType")] 
		public CInt32 StartType
		{
			get
			{
				if (_startType == null)
				{
					_startType = (CInt32) CR2WTypeManager.Create("Int32", "startType", cr2w, this);
				}
				return _startType;
			}
			set
			{
				if (_startType == value)
				{
					return;
				}
				_startType = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("startDirectionAngle")] 
		public CFloat StartDirectionAngle
		{
			get
			{
				if (_startDirectionAngle == null)
				{
					_startDirectionAngle = (CFloat) CR2WTypeManager.Create("Float", "startDirectionAngle", cr2w, this);
				}
				return _startDirectionAngle;
			}
			set
			{
				if (_startDirectionAngle == value)
				{
					return;
				}
				_startDirectionAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("animTime")] 
		public CFloat AnimTime
		{
			get
			{
				if (_animTime == null)
				{
					_animTime = (CFloat) CR2WTypeManager.Create("Float", "animTime", cr2w, this);
				}
				return _animTime;
			}
			set
			{
				if (_animTime == value)
				{
					return;
				}
				_animTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get
			{
				if (_isBlocked == null)
				{
					_isBlocked = (CBool) CR2WTypeManager.Create("Bool", "isBlocked", cr2w, this);
				}
				return _isBlocked;
			}
			set
			{
				if (_isBlocked == value)
				{
					return;
				}
				_isBlocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bumpType")] 
		public CInt32 BumpType
		{
			get
			{
				if (_bumpType == null)
				{
					_bumpType = (CInt32) CR2WTypeManager.Create("Int32", "bumpType", cr2w, this);
				}
				return _bumpType;
			}
			set
			{
				if (_bumpType == value)
				{
					return;
				}
				_bumpType = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("fleeType")] 
		public CInt32 FleeType
		{
			get
			{
				if (_fleeType == null)
				{
					_fleeType = (CInt32) CR2WTypeManager.Create("Int32", "fleeType", cr2w, this);
				}
				return _fleeType;
			}
			set
			{
				if (_fleeType == value)
				{
					return;
				}
				_fleeType = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_Crowd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
