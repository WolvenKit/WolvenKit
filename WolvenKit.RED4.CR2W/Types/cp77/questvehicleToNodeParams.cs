using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questvehicleToNodeParams : questVehicleSpecificCommandParams
	{
		private CBool _stopAtEnd;
		private NodeRef _nodeRef;
		private CBool _isPlayer;
		private CBool _useTraffic;
		private CFloat _speedInTraffic;
		private CBool _forceGreenLights;
		private CHandle<vehiclePortalsList> _portals;
		private CBool _trafficTryNeighborsForStart;
		private CBool _trafficTryNeighborsForEnd;

		[Ordinal(3)] 
		[RED("stopAtEnd")] 
		public CBool StopAtEnd
		{
			get
			{
				if (_stopAtEnd == null)
				{
					_stopAtEnd = (CBool) CR2WTypeManager.Create("Bool", "stopAtEnd", cr2w, this);
				}
				return _stopAtEnd;
			}
			set
			{
				if (_stopAtEnd == value)
				{
					return;
				}
				_stopAtEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "nodeRef", cr2w, this);
				}
				return _nodeRef;
			}
			set
			{
				if (_nodeRef == value)
				{
					return;
				}
				_nodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get
			{
				if (_useTraffic == null)
				{
					_useTraffic = (CBool) CR2WTypeManager.Create("Bool", "useTraffic", cr2w, this);
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

		[Ordinal(7)] 
		[RED("speedInTraffic")] 
		public CFloat SpeedInTraffic
		{
			get
			{
				if (_speedInTraffic == null)
				{
					_speedInTraffic = (CFloat) CR2WTypeManager.Create("Float", "speedInTraffic", cr2w, this);
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

		[Ordinal(8)] 
		[RED("forceGreenLights")] 
		public CBool ForceGreenLights
		{
			get
			{
				if (_forceGreenLights == null)
				{
					_forceGreenLights = (CBool) CR2WTypeManager.Create("Bool", "forceGreenLights", cr2w, this);
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

		[Ordinal(9)] 
		[RED("portals")] 
		public CHandle<vehiclePortalsList> Portals
		{
			get
			{
				if (_portals == null)
				{
					_portals = (CHandle<vehiclePortalsList>) CR2WTypeManager.Create("handle:vehiclePortalsList", "portals", cr2w, this);
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

		[Ordinal(10)] 
		[RED("trafficTryNeighborsForStart")] 
		public CBool TrafficTryNeighborsForStart
		{
			get
			{
				if (_trafficTryNeighborsForStart == null)
				{
					_trafficTryNeighborsForStart = (CBool) CR2WTypeManager.Create("Bool", "trafficTryNeighborsForStart", cr2w, this);
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

		[Ordinal(11)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CBool TrafficTryNeighborsForEnd
		{
			get
			{
				if (_trafficTryNeighborsForEnd == null)
				{
					_trafficTryNeighborsForEnd = (CBool) CR2WTypeManager.Create("Bool", "trafficTryNeighborsForEnd", cr2w, this);
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

		public questvehicleToNodeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
