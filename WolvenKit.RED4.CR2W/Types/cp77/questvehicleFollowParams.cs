using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questvehicleFollowParams : questVehicleSpecificCommandParams
	{
		private gameEntityReference _targetEntRef;
		private CFloat _distanceMin;
		private CFloat _distanceMax;
		private CBool _isPlayer;
		private CBool _stopWhenTargetReached;
		private CBool _useTraffic;
		private CBool _trafficTryNeighborsForStart;
		private CBool _trafficTryNeighborsForEnd;

		[Ordinal(3)] 
		[RED("targetEntRef")] 
		public gameEntityReference TargetEntRef
		{
			get
			{
				if (_targetEntRef == null)
				{
					_targetEntRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "targetEntRef", cr2w, this);
				}
				return _targetEntRef;
			}
			set
			{
				if (_targetEntRef == value)
				{
					return;
				}
				_targetEntRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		public questvehicleFollowParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
