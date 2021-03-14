using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIVehicleFollowCommand : AIVehicleCommand
	{
		private wCHandle<gameObject> _target;
		private CFloat _secureTimeOut;
		private CFloat _distanceMin;
		private CFloat _distanceMax;
		private CBool _stopWhenTargetReached;
		private CBool _useTraffic;
		private CBool _trafficTryNeighborsForStart;
		private CBool _trafficTryNeighborsForEnd;
		private CBool _allowStubMovement;

		[Ordinal(6)] 
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
		[RED("distanceMin")] 
		public CFloat DistanceMin
		{
			get
			{
				if (_distanceMin == null)
				{
					_distanceMin = (CFloat) CR2WTypeManager.Create("Float", "distanceMin", cr2w, this);
				}
				return _distanceMin;
			}
			set
			{
				if (_distanceMin == value)
				{
					return;
				}
				_distanceMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("distanceMax")] 
		public CFloat DistanceMax
		{
			get
			{
				if (_distanceMax == null)
				{
					_distanceMax = (CFloat) CR2WTypeManager.Create("Float", "distanceMax", cr2w, this);
				}
				return _distanceMax;
			}
			set
			{
				if (_distanceMax == value)
				{
					return;
				}
				_distanceMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("stopWhenTargetReached")] 
		public CBool StopWhenTargetReached
		{
			get
			{
				if (_stopWhenTargetReached == null)
				{
					_stopWhenTargetReached = (CBool) CR2WTypeManager.Create("Bool", "stopWhenTargetReached", cr2w, this);
				}
				return _stopWhenTargetReached;
			}
			set
			{
				if (_stopWhenTargetReached == value)
				{
					return;
				}
				_stopWhenTargetReached = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("allowStubMovement")] 
		public CBool AllowStubMovement
		{
			get
			{
				if (_allowStubMovement == null)
				{
					_allowStubMovement = (CBool) CR2WTypeManager.Create("Bool", "allowStubMovement", cr2w, this);
				}
				return _allowStubMovement;
			}
			set
			{
				if (_allowStubMovement == value)
				{
					return;
				}
				_allowStubMovement = value;
				PropertySet(this);
			}
		}

		public AIVehicleFollowCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
