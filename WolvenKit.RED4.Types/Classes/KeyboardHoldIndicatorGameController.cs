using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class KeyboardHoldIndicatorGameController : gameuiHoldIndicatorGameController
	{
		private inkImageWidgetReference _progress;

		[Ordinal(6)] 
		[RED("progress")] 
		public inkImageWidgetReference Progress
		{
			get => GetProperty(ref _progress);
			set => SetProperty(ref _progress, value);
		}
	}
}
