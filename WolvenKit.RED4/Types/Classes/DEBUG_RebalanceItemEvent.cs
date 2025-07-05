using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DEBUG_RebalanceItemEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("reqLevel")] 
		public CFloat ReqLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DEBUG_RebalanceItemEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
