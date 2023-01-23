using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StimBroadcasterComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("activeRequests")] 
		public CArray<CHandle<StimRequest>> ActiveRequests
		{
			get => GetPropertyValue<CArray<CHandle<StimRequest>>>();
			set => SetPropertyValue<CArray<CHandle<StimRequest>>>(value);
		}

		[Ordinal(6)] 
		[RED("currentID")] 
		public CUInt32 CurrentID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("shouldBroadcast")] 
		public CBool ShouldBroadcast
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("targets")] 
		public CArray<gameNPCstubData> Targets
		{
			get => GetPropertyValue<CArray<gameNPCstubData>>();
			set => SetPropertyValue<CArray<gameNPCstubData>>(value);
		}

		[Ordinal(9)] 
		[RED("blockedStims")] 
		public CArray<StimIdentificationData> BlockedStims
		{
			get => GetPropertyValue<CArray<StimIdentificationData>>();
			set => SetPropertyValue<CArray<StimIdentificationData>>(value);
		}

		[Ordinal(10)] 
		[RED("fallbackInterval")] 
		public CFloat FallbackInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public StimBroadcasterComponent()
		{
			ActiveRequests = new();
			Targets = new();
			BlockedStims = new();
			FallbackInterval = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
