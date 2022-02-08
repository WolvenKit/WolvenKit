using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DropPointTerminalInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("sellAction")] 
		public inkWidgetReference SellAction
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public DropPointTerminalInkGameController()
		{
			SellAction = new();
		}
	}
}
