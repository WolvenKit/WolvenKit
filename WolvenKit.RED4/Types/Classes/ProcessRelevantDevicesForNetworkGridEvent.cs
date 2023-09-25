using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProcessRelevantDevicesForNetworkGridEvent : ProcessDevicesEvent
	{
		[Ordinal(1)] 
		[RED("ignoreRevealed")] 
		public CBool IgnoreRevealed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("finalizeRegistrationAsMaster")] 
		public CBool FinalizeRegistrationAsMaster
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("breachedResource")] 
		public gameFxResource BreachedResource
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(4)] 
		[RED("defaultResource")] 
		public gameFxResource DefaultResource
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(5)] 
		[RED("isPing")] 
		public CBool IsPing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("lifetime")] 
		public CFloat Lifetime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ProcessRelevantDevicesForNetworkGridEvent()
		{
			BreachedResource = new gameFxResource();
			DefaultResource = new gameFxResource();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
