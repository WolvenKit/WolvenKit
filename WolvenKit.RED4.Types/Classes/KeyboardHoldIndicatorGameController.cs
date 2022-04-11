using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			Progress = new();
		}
	}
}
