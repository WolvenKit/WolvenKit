using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveToNodeTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _useKinematic;
		private CHandle<AIArgumentMapping> _needDriver;
		private CHandle<AIArgumentMapping> _nodeRef;
		private CHandle<AIArgumentMapping> _stopAtPathEnd;
		private CHandle<AIArgumentMapping> _secureTimeOut;
		private CHandle<AIArgumentMapping> _isPlayer;
		private CHandle<AIArgumentMapping> _useTraffic;
		private CHandle<AIArgumentMapping> _speedInTraffic;
		private CHandle<AIArgumentMapping> _forceGreenLights;
		private CHandle<AIArgumentMapping> _portals;
		private CHandle<AIArgumentMapping> _trafficTryNeighborsForStart;
		private CHandle<AIArgumentMapping> _trafficTryNeighborsForEnd;

		[Ordinal(1)] 
		[RED("useKinematic")] 
		public CHandle<AIArgumentMapping> UseKinematic
		{
			get => GetProperty(ref _useKinematic);
			set => SetProperty(ref _useKinematic, value);
		}

		[Ordinal(2)] 
		[RED("needDriver")] 
		public CHandle<AIArgumentMapping> NeedDriver
		{
			get => GetProperty(ref _needDriver);
			set => SetProperty(ref _needDriver, value);
		}

		[Ordinal(3)] 
		[RED("nodeRef")] 
		public CHandle<AIArgumentMapping> NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(4)] 
		[RED("stopAtPathEnd")] 
		public CHandle<AIArgumentMapping> StopAtPathEnd
		{
			get => GetProperty(ref _stopAtPathEnd);
			set => SetProperty(ref _stopAtPathEnd, value);
		}

		[Ordinal(5)] 
		[RED("secureTimeOut")] 
		public CHandle<AIArgumentMapping> SecureTimeOut
		{
			get => GetProperty(ref _secureTimeOut);
			set => SetProperty(ref _secureTimeOut, value);
		}

		[Ordinal(6)] 
		[RED("isPlayer")] 
		public CHandle<AIArgumentMapping> IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(7)] 
		[RED("useTraffic")] 
		public CHandle<AIArgumentMapping> UseTraffic
		{
			get => GetProperty(ref _useTraffic);
			set => SetProperty(ref _useTraffic, value);
		}

		[Ordinal(8)] 
		[RED("speedInTraffic")] 
		public CHandle<AIArgumentMapping> SpeedInTraffic
		{
			get => GetProperty(ref _speedInTraffic);
			set => SetProperty(ref _speedInTraffic, value);
		}

		[Ordinal(9)] 
		[RED("forceGreenLights")] 
		public CHandle<AIArgumentMapping> ForceGreenLights
		{
			get => GetProperty(ref _forceGreenLights);
			set => SetProperty(ref _forceGreenLights, value);
		}

		[Ordinal(10)] 
		[RED("portals")] 
		public CHandle<AIArgumentMapping> Portals
		{
			get => GetProperty(ref _portals);
			set => SetProperty(ref _portals, value);
		}

		[Ordinal(11)] 
		[RED("trafficTryNeighborsForStart")] 
		public CHandle<AIArgumentMapping> TrafficTryNeighborsForStart
		{
			get => GetProperty(ref _trafficTryNeighborsForStart);
			set => SetProperty(ref _trafficTryNeighborsForStart, value);
		}

		[Ordinal(12)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CHandle<AIArgumentMapping> TrafficTryNeighborsForEnd
		{
			get => GetProperty(ref _trafficTryNeighborsForEnd);
			set => SetProperty(ref _trafficTryNeighborsForEnd, value);
		}

		public AIbehaviorDriveToNodeTreeNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
