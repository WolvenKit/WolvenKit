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
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(2)] 
		[RED("secureTimeOut")] 
		public CHandle<AIArgumentMapping> SecureTimeOut
		{
			get => GetProperty(ref _secureTimeOut);
			set => SetProperty(ref _secureTimeOut, value);
		}

		[Ordinal(3)] 
		[RED("useTraffic")] 
		public CHandle<AIArgumentMapping> UseTraffic
		{
			get => GetProperty(ref _useTraffic);
			set => SetProperty(ref _useTraffic, value);
		}

		[Ordinal(4)] 
		[RED("speedInTraffic")] 
		public CHandle<AIArgumentMapping> SpeedInTraffic
		{
			get => GetProperty(ref _speedInTraffic);
			set => SetProperty(ref _speedInTraffic, value);
		}

		[Ordinal(5)] 
		[RED("forceGreenLights")] 
		public CHandle<AIArgumentMapping> ForceGreenLights
		{
			get => GetProperty(ref _forceGreenLights);
			set => SetProperty(ref _forceGreenLights, value);
		}

		[Ordinal(6)] 
		[RED("portals")] 
		public CHandle<AIArgumentMapping> Portals
		{
			get => GetProperty(ref _portals);
			set => SetProperty(ref _portals, value);
		}

		[Ordinal(7)] 
		[RED("trafficTryNeighborsForStart")] 
		public CHandle<AIArgumentMapping> TrafficTryNeighborsForStart
		{
			get => GetProperty(ref _trafficTryNeighborsForStart);
			set => SetProperty(ref _trafficTryNeighborsForStart, value);
		}

		[Ordinal(8)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CHandle<AIArgumentMapping> TrafficTryNeighborsForEnd
		{
			get => GetProperty(ref _trafficTryNeighborsForEnd);
			set => SetProperty(ref _trafficTryNeighborsForEnd, value);
		}

		public AIbehaviorDriveToPointTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
