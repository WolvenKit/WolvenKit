using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIDriveFollowCommandHandler : AICommandHandlerBase
	{
		[Ordinal(1)] 
		[RED("outUseKinematic")] 
		public CHandle<AIArgumentMapping> OutUseKinematic
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("outNeedDriver")] 
		public CHandle<AIArgumentMapping> OutNeedDriver
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(3)] 
		[RED("outTarget")] 
		public CHandle<AIArgumentMapping> OutTarget
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(4)] 
		[RED("outSecureTimeOut")] 
		public CHandle<AIArgumentMapping> OutSecureTimeOut
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(5)] 
		[RED("outDistanceMin")] 
		public CHandle<AIArgumentMapping> OutDistanceMin
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(6)] 
		[RED("outDistanceMax")] 
		public CHandle<AIArgumentMapping> OutDistanceMax
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(7)] 
		[RED("outStopWhenTargetReached")] 
		public CHandle<AIArgumentMapping> OutStopWhenTargetReached
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(8)] 
		[RED("outUseTraffic")] 
		public CHandle<AIArgumentMapping> OutUseTraffic
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(9)] 
		[RED("outTrafficTryNeighborsForStart")] 
		public CHandle<AIArgumentMapping> OutTrafficTryNeighborsForStart
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(10)] 
		[RED("outTrafficTryNeighborsForEnd")] 
		public CHandle<AIArgumentMapping> OutTrafficTryNeighborsForEnd
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIDriveFollowCommandHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
