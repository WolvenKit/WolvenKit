using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDriveFollowCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outUseKinematic;
		private CHandle<AIArgumentMapping> _outNeedDriver;
		private CHandle<AIArgumentMapping> _outTarget;
		private CHandle<AIArgumentMapping> _outSecureTimeOut;
		private CHandle<AIArgumentMapping> _outDistanceMin;
		private CHandle<AIArgumentMapping> _outDistanceMax;
		private CHandle<AIArgumentMapping> _outStopWhenTargetReached;
		private CHandle<AIArgumentMapping> _outUseTraffic;
		private CHandle<AIArgumentMapping> _outTrafficTryNeighborsForStart;
		private CHandle<AIArgumentMapping> _outTrafficTryNeighborsForEnd;
		private CHandle<AIArgumentMapping> _outAllowStubMovement;

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
		[RED("outTarget")] 
		public CHandle<AIArgumentMapping> OutTarget
		{
			get
			{
				if (_outTarget == null)
				{
					_outTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outTarget", cr2w, this);
				}
				return _outTarget;
			}
			set
			{
				if (_outTarget == value)
				{
					return;
				}
				_outTarget = value;
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
		[RED("outDistanceMin")] 
		public CHandle<AIArgumentMapping> OutDistanceMin
		{
			get
			{
				if (_outDistanceMin == null)
				{
					_outDistanceMin = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outDistanceMin", cr2w, this);
				}
				return _outDistanceMin;
			}
			set
			{
				if (_outDistanceMin == value)
				{
					return;
				}
				_outDistanceMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("outDistanceMax")] 
		public CHandle<AIArgumentMapping> OutDistanceMax
		{
			get
			{
				if (_outDistanceMax == null)
				{
					_outDistanceMax = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outDistanceMax", cr2w, this);
				}
				return _outDistanceMax;
			}
			set
			{
				if (_outDistanceMax == value)
				{
					return;
				}
				_outDistanceMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("outStopWhenTargetReached")] 
		public CHandle<AIArgumentMapping> OutStopWhenTargetReached
		{
			get
			{
				if (_outStopWhenTargetReached == null)
				{
					_outStopWhenTargetReached = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outStopWhenTargetReached", cr2w, this);
				}
				return _outStopWhenTargetReached;
			}
			set
			{
				if (_outStopWhenTargetReached == value)
				{
					return;
				}
				_outStopWhenTargetReached = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("outUseTraffic")] 
		public CHandle<AIArgumentMapping> OutUseTraffic
		{
			get
			{
				if (_outUseTraffic == null)
				{
					_outUseTraffic = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outUseTraffic", cr2w, this);
				}
				return _outUseTraffic;
			}
			set
			{
				if (_outUseTraffic == value)
				{
					return;
				}
				_outUseTraffic = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("outTrafficTryNeighborsForStart")] 
		public CHandle<AIArgumentMapping> OutTrafficTryNeighborsForStart
		{
			get
			{
				if (_outTrafficTryNeighborsForStart == null)
				{
					_outTrafficTryNeighborsForStart = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outTrafficTryNeighborsForStart", cr2w, this);
				}
				return _outTrafficTryNeighborsForStart;
			}
			set
			{
				if (_outTrafficTryNeighborsForStart == value)
				{
					return;
				}
				_outTrafficTryNeighborsForStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("outTrafficTryNeighborsForEnd")] 
		public CHandle<AIArgumentMapping> OutTrafficTryNeighborsForEnd
		{
			get
			{
				if (_outTrafficTryNeighborsForEnd == null)
				{
					_outTrafficTryNeighborsForEnd = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outTrafficTryNeighborsForEnd", cr2w, this);
				}
				return _outTrafficTryNeighborsForEnd;
			}
			set
			{
				if (_outTrafficTryNeighborsForEnd == value)
				{
					return;
				}
				_outTrafficTryNeighborsForEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("outAllowStubMovement")] 
		public CHandle<AIArgumentMapping> OutAllowStubMovement
		{
			get
			{
				if (_outAllowStubMovement == null)
				{
					_outAllowStubMovement = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outAllowStubMovement", cr2w, this);
				}
				return _outAllowStubMovement;
			}
			set
			{
				if (_outAllowStubMovement == value)
				{
					return;
				}
				_outAllowStubMovement = value;
				PropertySet(this);
			}
		}

		public AIDriveFollowCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
