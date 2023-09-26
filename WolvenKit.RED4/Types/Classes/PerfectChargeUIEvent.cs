using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerfectChargeUIEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CName Type
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PerfectChargeUIEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
