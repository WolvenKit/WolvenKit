using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FrameInkGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("screenshotWidget")] 
		public inkImageWidgetReference ScreenshotWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("defaultScreenshotWidget")] 
		public inkImageWidgetReference DefaultScreenshotWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public FrameInkGameController()
		{
			ScreenshotWidget = new inkImageWidgetReference();
			DefaultScreenshotWidget = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
