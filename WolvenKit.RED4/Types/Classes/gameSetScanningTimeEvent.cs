using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSetScanningTimeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameSetScanningTimeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
