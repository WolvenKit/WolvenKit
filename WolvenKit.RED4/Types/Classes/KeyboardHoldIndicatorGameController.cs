using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class KeyboardHoldIndicatorGameController : gameuiHoldIndicatorGameController
	{
		[Ordinal(6)] 
		[RED("progress")] 
		public inkImageWidgetReference Progress
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public KeyboardHoldIndicatorGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
