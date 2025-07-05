using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OnSpecialQuickhackTriggeredEvent : DelayEvent
	{
		[Ordinal(39)] 
		[RED("quickhackData")] 
		public CHandle<QuickhackData> QuickhackData
		{
			get => GetPropertyValue<CHandle<QuickhackData>>();
			set => SetPropertyValue<CHandle<QuickhackData>>(value);
		}

		public OnSpecialQuickhackTriggeredEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
