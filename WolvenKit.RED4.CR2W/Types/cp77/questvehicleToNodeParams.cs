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
			get => GetProperty(ref _stopAtEnd);
			set => SetProperty(ref _stopAtEnd, value);
		}

		[Ordinal(4)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(5)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(6)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get => GetProperty(ref _useTraffic);
			set => SetProperty(ref _useTraffic, value);
		}

		[Ordinal(7)] 
		[RED("speedInTraffic")] 
		public CFloat SpeedInTraffic
		{
			get => GetProperty(ref _speedInTraffic);
			set => SetProperty(ref _speedInTraffic, value);
		}

		[Ordinal(8)] 
		[RED("forceGreenLights")] 
		public CBool ForceGreenLights
		{
			get => GetProperty(ref _forceGreenLights);
			set => SetProperty(ref _forceGreenLights, value);
		}

		[Ordinal(9)] 
		[RED("portals")] 
		public CHandle<vehiclePortalsList> Portals
		{
			get => GetProperty(ref _portals);
			set => SetProperty(ref _portals, value);
		}

		[Ordinal(10)] 
		[RED("trafficTryNeighborsForStart")] 
		public CBool TrafficTryNeighborsForStart
		{
			get => GetProperty(ref _trafficTryNeighborsForStart);
			set => SetProperty(ref _trafficTryNeighborsForStart, value);
		}

		[Ordinal(11)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CBool TrafficTryNeighborsForEnd
		{
			get => GetProperty(ref _trafficTryNeighborsForEnd);
			set => SetProperty(ref _trafficTryNeighborsForEnd, value);
		}

		public questvehicleToNodeParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
