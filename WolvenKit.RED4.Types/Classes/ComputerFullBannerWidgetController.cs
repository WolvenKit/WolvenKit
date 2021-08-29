using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ComputerFullBannerWidgetController : ComputerBannerWidgetController
	{
		private inkWidgetReference _closeButtonWidget;

		[Ordinal(12)] 
		[RED("closeButtonWidget")] 
		public inkWidgetReference CloseButtonWidget
		{
			get => GetProperty(ref _closeButtonWidget);
			set => SetProperty(ref _closeButtonWidget, value);
		}
	}
}
