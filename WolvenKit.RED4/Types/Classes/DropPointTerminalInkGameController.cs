using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
		[RED("statusText")] 
		public inkTextWidgetReference StatusText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public DropPointTerminalInkGameController()
		{
			SellAction = new inkWidgetReference();
			StatusText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
