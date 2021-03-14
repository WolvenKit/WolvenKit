using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDriveToNodeCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outUseKinematic;
		private CHandle<AIArgumentMapping> _outNeedDriver;
		private CHandle<AIArgumentMapping> _outNodeRef;
		private CHandle<AIArgumentMapping> _outSecureTimeOut;
		private CHandle<AIArgumentMapping> _outIsPlayer;
		private CHandle<AIArgumentMapping> _outUseTraffic;
		private CHandle<AIArgumentMapping> _forceGreenLights;
		private CHandle<AIArgumentMapping> _portals;
		private CHandle<AIArgumentMapping> _outTrafficTryNeighborsForStart;
		private CHandle<AIArgumentMapping> _outTrafficTryNeighborsForEnd;

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
		[RED("outNodeRef")] 
		public CHandle<AIArgumentMapping> OutNodeRef
		{
			get
			{
				if (_outNodeRef == null)
				{
					_outNodeRef = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outNodeRef", cr2w, this);
				}
				return _outNodeRef;
			}
			set
			{
				if (_outNodeRef == value)
				{
					return;
				}
				_outNodeRef = value;
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
		[RED("outIsPlayer")] 
		public CHandle<AIArgumentMapping> OutIsPlayer
		{
			get
			{
				if (_outIsPlayer == null)
				{
					_outIsPlayer = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outIsPlayer", cr2w, this);
				}
				return _outIsPlayer;
			}
			set
			{
				if (_outIsPlayer == value)
				{
					return;
				}
				_outIsPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("forceGreenLights")] 
		public CHandle<AIArgumentMapping> ForceGreenLights
		{
			get
			{
				if (_forceGreenLights == null)
				{
					_forceGreenLights = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "forceGreenLights", cr2w, this);
				}
				return _forceGreenLights;
			}
			set
			{
				if (_forceGreenLights == value)
				{
					return;
				}
				_forceGreenLights = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("portals")] 
		public CHandle<AIArgumentMapping> Portals
		{
			get
			{
				if (_portals == null)
				{
					_portals = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "portals", cr2w, this);
				}
				return _portals;
			}
			set
			{
				if (_portals == value)
				{
					return;
				}
				_portals = value;
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

		public AIDriveToNodeCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
