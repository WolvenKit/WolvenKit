using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIDriveToNodeCommandHandler : AICommandHandlerBase
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
			get => GetProperty(ref _outUseKinematic);
			set => SetProperty(ref _outUseKinematic, value);
		}

		[Ordinal(2)] 
		[RED("outNeedDriver")] 
		public CHandle<AIArgumentMapping> OutNeedDriver
		{
			get => GetProperty(ref _outNeedDriver);
			set => SetProperty(ref _outNeedDriver, value);
		}

		[Ordinal(3)] 
		[RED("outNodeRef")] 
		public CHandle<AIArgumentMapping> OutNodeRef
		{
			get => GetProperty(ref _outNodeRef);
			set => SetProperty(ref _outNodeRef, value);
		}

		[Ordinal(4)] 
		[RED("outSecureTimeOut")] 
		public CHandle<AIArgumentMapping> OutSecureTimeOut
		{
			get => GetProperty(ref _outSecureTimeOut);
			set => SetProperty(ref _outSecureTimeOut, value);
		}

		[Ordinal(5)] 
		[RED("outIsPlayer")] 
		public CHandle<AIArgumentMapping> OutIsPlayer
		{
			get => GetProperty(ref _outIsPlayer);
			set => SetProperty(ref _outIsPlayer, value);
		}

		[Ordinal(6)] 
		[RED("outUseTraffic")] 
		public CHandle<AIArgumentMapping> OutUseTraffic
		{
			get => GetProperty(ref _outUseTraffic);
			set => SetProperty(ref _outUseTraffic, value);
		}

		[Ordinal(7)] 
		[RED("forceGreenLights")] 
		public CHandle<AIArgumentMapping> ForceGreenLights
		{
			get => GetProperty(ref _forceGreenLights);
			set => SetProperty(ref _forceGreenLights, value);
		}

		[Ordinal(8)] 
		[RED("portals")] 
		public CHandle<AIArgumentMapping> Portals
		{
			get => GetProperty(ref _portals);
			set => SetProperty(ref _portals, value);
		}

		[Ordinal(9)] 
		[RED("outTrafficTryNeighborsForStart")] 
		public CHandle<AIArgumentMapping> OutTrafficTryNeighborsForStart
		{
			get => GetProperty(ref _outTrafficTryNeighborsForStart);
			set => SetProperty(ref _outTrafficTryNeighborsForStart, value);
		}

		[Ordinal(10)] 
		[RED("outTrafficTryNeighborsForEnd")] 
		public CHandle<AIArgumentMapping> OutTrafficTryNeighborsForEnd
		{
			get => GetProperty(ref _outTrafficTryNeighborsForEnd);
			set => SetProperty(ref _outTrafficTryNeighborsForEnd, value);
		}
	}
}
