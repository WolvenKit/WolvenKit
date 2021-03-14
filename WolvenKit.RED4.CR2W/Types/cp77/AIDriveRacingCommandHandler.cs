using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDriveRacingCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outUseKinematic;
		private CHandle<AIArgumentMapping> _outNeedDriver;
		private CHandle<AIArgumentMapping> _outSpline;
		private CHandle<AIArgumentMapping> _outSecureTimeOut;
		private CHandle<AIArgumentMapping> _outDriveBackwards;
		private CHandle<AIArgumentMapping> _outReverseSpline;
		private CHandle<AIArgumentMapping> _outStartFromClosest;
		private CHandle<AIArgumentMapping> _outRubberBandingBool;
		private CHandle<AIArgumentMapping> _outRubberBandingTargetRef;
		private CHandle<AIArgumentMapping> _outRubberBandingMinDistance;
		private CHandle<AIArgumentMapping> _outRubberBandingMaxDistance;
		private CHandle<AIArgumentMapping> _outRubberBandingStopAndWait;
		private CHandle<AIArgumentMapping> _outRubberBandingTeleportToCatchUp;
		private CHandle<AIArgumentMapping> _outRubberBandingStayInFront;

		[Ordinal(1)] 
		[RED("outUseKinematic")] 
		public CHandle<AIArgumentMapping> OutUseKinematic
		{
			get
			{
				if (_outUseKinematic == null)
				{
					_outUseKinematic = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outUseKinematic", cr2w, this);
				}
				return _outUseKinematic;
			}
			set
			{
				if (_outUseKinematic == value)
				{
					return;
				}
				_outUseKinematic = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outNeedDriver")] 
		public CHandle<AIArgumentMapping> OutNeedDriver
		{
			get
			{
				if (_outNeedDriver == null)
				{
					_outNeedDriver = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outNeedDriver", cr2w, this);
				}
				return _outNeedDriver;
			}
			set
			{
				if (_outNeedDriver == value)
				{
					return;
				}
				_outNeedDriver = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("outSpline")] 
		public CHandle<AIArgumentMapping> OutSpline
		{
			get
			{
				if (_outSpline == null)
				{
					_outSpline = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outSpline", cr2w, this);
				}
				return _outSpline;
			}
			set
			{
				if (_outSpline == value)
				{
					return;
				}
				_outSpline = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("outSecureTimeOut")] 
		public CHandle<AIArgumentMapping> OutSecureTimeOut
		{
			get
			{
				if (_outSecureTimeOut == null)
				{
					_outSecureTimeOut = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outSecureTimeOut", cr2w, this);
				}
				return _outSecureTimeOut;
			}
			set
			{
				if (_outSecureTimeOut == value)
				{
					return;
				}
				_outSecureTimeOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("outDriveBackwards")] 
		public CHandle<AIArgumentMapping> OutDriveBackwards
		{
			get
			{
				if (_outDriveBackwards == null)
				{
					_outDriveBackwards = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outDriveBackwards", cr2w, this);
				}
				return _outDriveBackwards;
			}
			set
			{
				if (_outDriveBackwards == value)
				{
					return;
				}
				_outDriveBackwards = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("outReverseSpline")] 
		public CHandle<AIArgumentMapping> OutReverseSpline
		{
			get
			{
				if (_outReverseSpline == null)
				{
					_outReverseSpline = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outReverseSpline", cr2w, this);
				}
				return _outReverseSpline;
			}
			set
			{
				if (_outReverseSpline == value)
				{
					return;
				}
				_outReverseSpline = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("outStartFromClosest")] 
		public CHandle<AIArgumentMapping> OutStartFromClosest
		{
			get
			{
				if (_outStartFromClosest == null)
				{
					_outStartFromClosest = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outStartFromClosest", cr2w, this);
				}
				return _outStartFromClosest;
			}
			set
			{
				if (_outStartFromClosest == value)
				{
					return;
				}
				_outStartFromClosest = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("outRubberBandingBool")] 
		public CHandle<AIArgumentMapping> OutRubberBandingBool
		{
			get
			{
				if (_outRubberBandingBool == null)
				{
					_outRubberBandingBool = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outRubberBandingBool", cr2w, this);
				}
				return _outRubberBandingBool;
			}
			set
			{
				if (_outRubberBandingBool == value)
				{
					return;
				}
				_outRubberBandingBool = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("outRubberBandingTargetRef")] 
		public CHandle<AIArgumentMapping> OutRubberBandingTargetRef
		{
			get
			{
				if (_outRubberBandingTargetRef == null)
				{
					_outRubberBandingTargetRef = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outRubberBandingTargetRef", cr2w, this);
				}
				return _outRubberBandingTargetRef;
			}
			set
			{
				if (_outRubberBandingTargetRef == value)
				{
					return;
				}
				_outRubberBandingTargetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("outRubberBandingMinDistance")] 
		public CHandle<AIArgumentMapping> OutRubberBandingMinDistance
		{
			get
			{
				if (_outRubberBandingMinDistance == null)
				{
					_outRubberBandingMinDistance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outRubberBandingMinDistance", cr2w, this);
				}
				return _outRubberBandingMinDistance;
			}
			set
			{
				if (_outRubberBandingMinDistance == value)
				{
					return;
				}
				_outRubberBandingMinDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("outRubberBandingMaxDistance")] 
		public CHandle<AIArgumentMapping> OutRubberBandingMaxDistance
		{
			get
			{
				if (_outRubberBandingMaxDistance == null)
				{
					_outRubberBandingMaxDistance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outRubberBandingMaxDistance", cr2w, this);
				}
				return _outRubberBandingMaxDistance;
			}
			set
			{
				if (_outRubberBandingMaxDistance == value)
				{
					return;
				}
				_outRubberBandingMaxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("outRubberBandingStopAndWait")] 
		public CHandle<AIArgumentMapping> OutRubberBandingStopAndWait
		{
			get
			{
				if (_outRubberBandingStopAndWait == null)
				{
					_outRubberBandingStopAndWait = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outRubberBandingStopAndWait", cr2w, this);
				}
				return _outRubberBandingStopAndWait;
			}
			set
			{
				if (_outRubberBandingStopAndWait == value)
				{
					return;
				}
				_outRubberBandingStopAndWait = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("outRubberBandingTeleportToCatchUp")] 
		public CHandle<AIArgumentMapping> OutRubberBandingTeleportToCatchUp
		{
			get
			{
				if (_outRubberBandingTeleportToCatchUp == null)
				{
					_outRubberBandingTeleportToCatchUp = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outRubberBandingTeleportToCatchUp", cr2w, this);
				}
				return _outRubberBandingTeleportToCatchUp;
			}
			set
			{
				if (_outRubberBandingTeleportToCatchUp == value)
				{
					return;
				}
				_outRubberBandingTeleportToCatchUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("outRubberBandingStayInFront")] 
		public CHandle<AIArgumentMapping> OutRubberBandingStayInFront
		{
			get
			{
				if (_outRubberBandingStayInFront == null)
				{
					_outRubberBandingStayInFront = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outRubberBandingStayInFront", cr2w, this);
				}
				return _outRubberBandingStayInFront;
			}
			set
			{
				if (_outRubberBandingStayInFront == value)
				{
					return;
				}
				_outRubberBandingStayInFront = value;
				PropertySet(this);
			}
		}

		public AIDriveRacingCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
