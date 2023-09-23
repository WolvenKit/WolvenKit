using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RecurrentStimuliEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("requestID")] 
		public StimRequestID RequestID
		{
			get => GetPropertyValue<StimRequestID>();
			set => SetPropertyValue<StimRequestID>(value);
		}

		public RecurrentStimuliEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
