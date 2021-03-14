using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveRacingTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _useKinematic;
		private CHandle<AIArgumentMapping> _needDriver;
		private CHandle<AIArgumentMapping> _spline;
		private CHandle<AIArgumentMapping> _secureTimeOut;
		private CHandle<AIArgumentMapping> _backwards;
		private CHandle<AIArgumentMapping> _reverse;
		private CHandle<AIArgumentMapping> _closest;
		private CHandle<AIArgumentMapping> _forcedStartSpeed;
		private CHandle<AIArgumentMapping> _stopAtPathEnd;
		private CHandle<AIArgumentMapping> _keepDistanceParamBool;
		private CHandle<AIArgumentMapping> _keepDistanceParamCompanion;
		private CHandle<AIArgumentMapping> _keepDistanceParamDistance;
		private CHandle<AIArgumentMapping> _rubberBandingBool;
		private CHandle<AIArgumentMapping> _rubberBandingTargetRef;
		private CHandle<AIArgumentMapping> _rubberBandingMinDistance;
		private CHandle<AIArgumentMapping> _rubberBandingMaxDistance;
		private CHandle<AIArgumentMapping> _rubberBandingStopAndWait;
		private CHandle<AIArgumentMapping> _rubberBandingTeleportToCatchUp;
		private CHandle<AIArgumentMapping> _rubberBandingStayInFront;

		[Ordinal(1)] 
		[RED("useKinematic")] 
		public CHandle<AIArgumentMapping> UseKinematic
		{
			get
			{
				if (_useKinematic == null)
				{
					_useKinematic = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "useKinematic", cr2w, this);
				}
				return _useKinematic;
			}
			set
			{
				if (_useKinematic == value)
				{
					return;
				}
				_useKinematic = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("needDriver")] 
		public CHandle<AIArgumentMapping> NeedDriver
		{
			get
			{
				if (_needDriver == null)
				{
					_needDriver = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "needDriver", cr2w, this);
				}
				return _needDriver;
			}
			set
			{
				if (_needDriver == value)
				{
					return;
				}
				_needDriver = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("spline")] 
		public CHandle<AIArgumentMapping> Spline
		{
			get
			{
				if (_spline == null)
				{
					_spline = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "spline", cr2w, this);
				}
				return _spline;
			}
			set
			{
				if (_spline == value)
				{
					return;
				}
				_spline = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("secureTimeOut")] 
		public CHandle<AIArgumentMapping> SecureTimeOut
		{
			get
			{
				if (_secureTimeOut == null)
				{
					_secureTimeOut = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "secureTimeOut", cr2w, this);
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

		[Ordinal(5)] 
		[RED("backwards")] 
		public CHandle<AIArgumentMapping> Backwards
		{
			get
			{
				if (_backwards == null)
				{
					_backwards = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "backwards", cr2w, this);
				}
				return _backwards;
			}
			set
			{
				if (_backwards == value)
				{
					return;
				}
				_backwards = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("reverse")] 
		public CHandle<AIArgumentMapping> Reverse
		{
			get
			{
				if (_reverse == null)
				{
					_reverse = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "reverse", cr2w, this);
				}
				return _reverse;
			}
			set
			{
				if (_reverse == value)
				{
					return;
				}
				_reverse = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("closest")] 
		public CHandle<AIArgumentMapping> Closest
		{
			get
			{
				if (_closest == null)
				{
					_closest = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "closest", cr2w, this);
				}
				return _closest;
			}
			set
			{
				if (_closest == value)
				{
					return;
				}
				_closest = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("forcedStartSpeed")] 
		public CHandle<AIArgumentMapping> ForcedStartSpeed
		{
			get
			{
				if (_forcedStartSpeed == null)
				{
					_forcedStartSpeed = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "forcedStartSpeed", cr2w, this);
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

		[Ordinal(9)] 
		[RED("stopAtPathEnd")] 
		public CHandle<AIArgumentMapping> StopAtPathEnd
		{
			get
			{
				if (_stopAtPathEnd == null)
				{
					_stopAtPathEnd = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "stopAtPathEnd", cr2w, this);
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

		[Ordinal(10)] 
		[RED("keepDistanceParamBool")] 
		public CHandle<AIArgumentMapping> KeepDistanceParamBool
		{
			get
			{
				if (_keepDistanceParamBool == null)
				{
					_keepDistanceParamBool = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "keepDistanceParamBool", cr2w, this);
				}
				return _keepDistanceParamBool;
			}
			set
			{
				if (_keepDistanceParamBool == value)
				{
					return;
				}
				_keepDistanceParamBool = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("keepDistanceParamCompanion")] 
		public CHandle<AIArgumentMapping> KeepDistanceParamCompanion
		{
			get
			{
				if (_keepDistanceParamCompanion == null)
				{
					_keepDistanceParamCompanion = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "keepDistanceParamCompanion", cr2w, this);
				}
				return _keepDistanceParamCompanion;
			}
			set
			{
				if (_keepDistanceParamCompanion == value)
				{
					return;
				}
				_keepDistanceParamCompanion = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("keepDistanceParamDistance")] 
		public CHandle<AIArgumentMapping> KeepDistanceParamDistance
		{
			get
			{
				if (_keepDistanceParamDistance == null)
				{
					_keepDistanceParamDistance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "keepDistanceParamDistance", cr2w, this);
				}
				return _keepDistanceParamDistance;
			}
			set
			{
				if (_keepDistanceParamDistance == value)
				{
					return;
				}
				_keepDistanceParamDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("rubberBandingBool")] 
		public CHandle<AIArgumentMapping> RubberBandingBool
		{
			get
			{
				if (_rubberBandingBool == null)
				{
					_rubberBandingBool = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "rubberBandingBool", cr2w, this);
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

		[Ordinal(14)] 
		[RED("rubberBandingTargetRef")] 
		public CHandle<AIArgumentMapping> RubberBandingTargetRef
		{
			get
			{
				if (_rubberBandingTargetRef == null)
				{
					_rubberBandingTargetRef = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "rubberBandingTargetRef", cr2w, this);
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

		[Ordinal(15)] 
		[RED("rubberBandingMinDistance")] 
		public CHandle<AIArgumentMapping> RubberBandingMinDistance
		{
			get
			{
				if (_rubberBandingMinDistance == null)
				{
					_rubberBandingMinDistance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "rubberBandingMinDistance", cr2w, this);
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

		[Ordinal(16)] 
		[RED("rubberBandingMaxDistance")] 
		public CHandle<AIArgumentMapping> RubberBandingMaxDistance
		{
			get
			{
				if (_rubberBandingMaxDistance == null)
				{
					_rubberBandingMaxDistance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "rubberBandingMaxDistance", cr2w, this);
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

		[Ordinal(17)] 
		[RED("rubberBandingStopAndWait")] 
		public CHandle<AIArgumentMapping> RubberBandingStopAndWait
		{
			get
			{
				if (_rubberBandingStopAndWait == null)
				{
					_rubberBandingStopAndWait = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "rubberBandingStopAndWait", cr2w, this);
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

		[Ordinal(18)] 
		[RED("rubberBandingTeleportToCatchUp")] 
		public CHandle<AIArgumentMapping> RubberBandingTeleportToCatchUp
		{
			get
			{
				if (_rubberBandingTeleportToCatchUp == null)
				{
					_rubberBandingTeleportToCatchUp = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "rubberBandingTeleportToCatchUp", cr2w, this);
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

		[Ordinal(19)] 
		[RED("rubberBandingStayInFront")] 
		public CHandle<AIArgumentMapping> RubberBandingStayInFront
		{
			get
			{
				if (_rubberBandingStayInFront == null)
				{
					_rubberBandingStayInFront = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "rubberBandingStayInFront", cr2w, this);
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

		public AIbehaviorDriveRacingTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
