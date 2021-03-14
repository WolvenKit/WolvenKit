using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIVehicleOnSplineCommand : AIVehicleCommand
	{
		private NodeRef _splineRef;
		private CFloat _secureTimeOut;
		private CBool _driveBackwards;
		private CBool _reverseSpline;
		private CBool _startFromClosest;
		private CFloat _forcedStartSpeed;
		private CBool _stopAtPathEnd;
		private CBool _keepDistanceBool;
		private wCHandle<gameObject> _keepDistanceCompanion;
		private CFloat _keepDistanceDistance;
		private CBool _rubberBandingBool;
		private wCHandle<gameObject> _rubberBandingTargetRef;
		private CFloat _rubberBandingMinDistance;
		private CFloat _rubberBandingMaxDistance;
		private CBool _rubberBandingStopAndWait;
		private CBool _rubberBandingTeleportToCatchUp;
		private CBool _rubberBandingStayInFront;

		[Ordinal(6)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get
			{
				if (_splineRef == null)
				{
					_splineRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "splineRef", cr2w, this);
				}
				return _splineRef;
			}
			set
			{
				if (_splineRef == value)
				{
					return;
				}
				_splineRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("secureTimeOut")] 
		public CFloat SecureTimeOut
		{
			get
			{
				if (_secureTimeOut == null)
				{
					_secureTimeOut = (CFloat) CR2WTypeManager.Create("Float", "secureTimeOut", cr2w, this);
				}
				return _secureTimeOut;
			}
			set
			{
				if (_secureTimeOut == value)
				{
					return;
				}
				_secureTimeOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("driveBackwards")] 
		public CBool DriveBackwards
		{
			get
			{
				if (_driveBackwards == null)
				{
					_driveBackwards = (CBool) CR2WTypeManager.Create("Bool", "driveBackwards", cr2w, this);
				}
				return _driveBackwards;
			}
			set
			{
				if (_driveBackwards == value)
				{
					return;
				}
				_driveBackwards = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get
			{
				if (_reverseSpline == null)
				{
					_reverseSpline = (CBool) CR2WTypeManager.Create("Bool", "reverseSpline", cr2w, this);
				}
				return _reverseSpline;
			}
			set
			{
				if (_reverseSpline == value)
				{
					return;
				}
				_reverseSpline = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("startFromClosest")] 
		public CBool StartFromClosest
		{
			get
			{
				if (_startFromClosest == null)
				{
					_startFromClosest = (CBool) CR2WTypeManager.Create("Bool", "startFromClosest", cr2w, this);
				}
				return _startFromClosest;
			}
			set
			{
				if (_startFromClosest == value)
				{
					return;
				}
				_startFromClosest = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("forcedStartSpeed")] 
		public CFloat ForcedStartSpeed
		{
			get
			{
				if (_forcedStartSpeed == null)
				{
					_forcedStartSpeed = (CFloat) CR2WTypeManager.Create("Float", "forcedStartSpeed", cr2w, this);
				}
				return _forcedStartSpeed;
			}
			set
			{
				if (_forcedStartSpeed == value)
				{
					return;
				}
				_forcedStartSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("stopAtPathEnd")] 
		public CBool StopAtPathEnd
		{
			get
			{
				if (_stopAtPathEnd == null)
				{
					_stopAtPathEnd = (CBool) CR2WTypeManager.Create("Bool", "stopAtPathEnd", cr2w, this);
				}
				return _stopAtPathEnd;
			}
			set
			{
				if (_stopAtPathEnd == value)
				{
					return;
				}
				_stopAtPathEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("keepDistanceBool")] 
		public CBool KeepDistanceBool
		{
			get
			{
				if (_keepDistanceBool == null)
				{
					_keepDistanceBool = (CBool) CR2WTypeManager.Create("Bool", "keepDistanceBool", cr2w, this);
				}
				return _keepDistanceBool;
			}
			set
			{
				if (_keepDistanceBool == value)
				{
					return;
				}
				_keepDistanceBool = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("keepDistanceCompanion")] 
		public wCHandle<gameObject> KeepDistanceCompanion
		{
			get
			{
				if (_keepDistanceCompanion == null)
				{
					_keepDistanceCompanion = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "keepDistanceCompanion", cr2w, this);
				}
				return _keepDistanceCompanion;
			}
			set
			{
				if (_keepDistanceCompanion == value)
				{
					return;
				}
				_keepDistanceCompanion = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("keepDistanceDistance")] 
		public CFloat KeepDistanceDistance
		{
			get
			{
				if (_keepDistanceDistance == null)
				{
					_keepDistanceDistance = (CFloat) CR2WTypeManager.Create("Float", "keepDistanceDistance", cr2w, this);
				}
				return _keepDistanceDistance;
			}
			set
			{
				if (_keepDistanceDistance == value)
				{
					return;
				}
				_keepDistanceDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("rubberBandingBool")] 
		public CBool RubberBandingBool
		{
			get
			{
				if (_rubberBandingBool == null)
				{
					_rubberBandingBool = (CBool) CR2WTypeManager.Create("Bool", "rubberBandingBool", cr2w, this);
				}
				return _rubberBandingBool;
			}
			set
			{
				if (_rubberBandingBool == value)
				{
					return;
				}
				_rubberBandingBool = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("rubberBandingTargetRef")] 
		public wCHandle<gameObject> RubberBandingTargetRef
		{
			get
			{
				if (_rubberBandingTargetRef == null)
				{
					_rubberBandingTargetRef = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "rubberBandingTargetRef", cr2w, this);
				}
				return _rubberBandingTargetRef;
			}
			set
			{
				if (_rubberBandingTargetRef == value)
				{
					return;
				}
				_rubberBandingTargetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("rubberBandingMinDistance")] 
		public CFloat RubberBandingMinDistance
		{
			get
			{
				if (_rubberBandingMinDistance == null)
				{
					_rubberBandingMinDistance = (CFloat) CR2WTypeManager.Create("Float", "rubberBandingMinDistance", cr2w, this);
				}
				return _rubberBandingMinDistance;
			}
			set
			{
				if (_rubberBandingMinDistance == value)
				{
					return;
				}
				_rubberBandingMinDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("rubberBandingMaxDistance")] 
		public CFloat RubberBandingMaxDistance
		{
			get
			{
				if (_rubberBandingMaxDistance == null)
				{
					_rubberBandingMaxDistance = (CFloat) CR2WTypeManager.Create("Float", "rubberBandingMaxDistance", cr2w, this);
				}
				return _rubberBandingMaxDistance;
			}
			set
			{
				if (_rubberBandingMaxDistance == value)
				{
					return;
				}
				_rubberBandingMaxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("rubberBandingStopAndWait")] 
		public CBool RubberBandingStopAndWait
		{
			get
			{
				if (_rubberBandingStopAndWait == null)
				{
					_rubberBandingStopAndWait = (CBool) CR2WTypeManager.Create("Bool", "rubberBandingStopAndWait", cr2w, this);
				}
				return _rubberBandingStopAndWait;
			}
			set
			{
				if (_rubberBandingStopAndWait == value)
				{
					return;
				}
				_rubberBandingStopAndWait = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("rubberBandingTeleportToCatchUp")] 
		public CBool RubberBandingTeleportToCatchUp
		{
			get
			{
				if (_rubberBandingTeleportToCatchUp == null)
				{
					_rubberBandingTeleportToCatchUp = (CBool) CR2WTypeManager.Create("Bool", "rubberBandingTeleportToCatchUp", cr2w, this);
				}
				return _rubberBandingTeleportToCatchUp;
			}
			set
			{
				if (_rubberBandingTeleportToCatchUp == value)
				{
					return;
				}
				_rubberBandingTeleportToCatchUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("rubberBandingStayInFront")] 
		public CBool RubberBandingStayInFront
		{
			get
			{
				if (_rubberBandingStayInFront == null)
				{
					_rubberBandingStayInFront = (CBool) CR2WTypeManager.Create("Bool", "rubberBandingStayInFront", cr2w, this);
				}
				return _rubberBandingStayInFront;
			}
			set
			{
				if (_rubberBandingStayInFront == value)
				{
					return;
				}
				_rubberBandingStayInFront = value;
				PropertySet(this);
			}
		}

		public AIVehicleOnSplineCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
