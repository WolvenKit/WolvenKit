using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveToPointTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _targetPosition;
		private CHandle<AIArgumentMapping> _secureTimeOut;
		private CHandle<AIArgumentMapping> _useTraffic;
		private CHandle<AIArgumentMapping> _speedInTraffic;
		private CHandle<AIArgumentMapping> _forceGreenLights;
		private CHandle<AIArgumentMapping> _portals;
		private CHandle<AIArgumentMapping> _trafficTryNeighborsForStart;
		private CHandle<AIArgumentMapping> _trafficTryNeighborsForEnd;

		[Ordinal(1)] 
		[RED("targetPosition")] 
		public CHandle<AIArgumentMapping> TargetPosition
		{
			get
			{
				if (_targetPosition == null)
				{
					_targetPosition = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "targetPosition", cr2w, this);
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("useTraffic")] 
		public CHandle<AIArgumentMapping> UseTraffic
		{
			get
			{
				if (_useTraffic == null)
				{
					_useTraffic = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "useTraffic", cr2w, this);
				}
				return _useTraffic;
			}
			set
			{
				if (_useTraffic == value)
				{
					return;
				}
				_useTraffic = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("speedInTraffic")] 
		public CHandle<AIArgumentMapping> SpeedInTraffic
		{
			get
			{
				if (_speedInTraffic == null)
				{
					_speedInTraffic = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "speedInTraffic", cr2w, this);
				}
				return _speedInTraffic;
			}
			set
			{
				if (_speedInTraffic == value)
				{
					return;
				}
				_speedInTraffic = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("trafficTryNeighborsForStart")] 
		public CHandle<AIArgumentMapping> TrafficTryNeighborsForStart
		{
			get
			{
				if (_trafficTryNeighborsForStart == null)
				{
					_trafficTryNeighborsForStart = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "trafficTryNeighborsForStart", cr2w, this);
				}
				return _trafficTryNeighborsForStart;
			}
			set
			{
				if (_trafficTryNeighborsForStart == value)
				{
					return;
				}
				_trafficTryNeighborsForStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CHandle<AIArgumentMapping> TrafficTryNeighborsForEnd
		{
			get
			{
				if (_trafficTryNeighborsForEnd == null)
				{
					_trafficTryNeighborsForEnd = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "trafficTryNeighborsForEnd", cr2w, this);
				}
				return _trafficTryNeighborsForEnd;
			}
			set
			{
				if (_trafficTryNeighborsForEnd == value)
				{
					return;
				}
				_trafficTryNeighborsForEnd = value;
				PropertySet(this);
			}
		}

		public AIbehaviorDriveToPointTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
