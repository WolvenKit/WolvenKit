using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HotkeyRadioWidgetController : gameuiNewPhoneRelatedHUDGameController
	{
		[Ordinal(13)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("DpadHintLibraryPath")] 
		public inkWidgetLibraryReference DpadHintLibraryPath
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		[Ordinal(15)] 
		[RED("IsInDriverCombat")] 
		public CBool IsInDriverCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("statusListener")] 
		public CHandle<HotkeyRadioStatusListener> StatusListener
		{
			get => GetPropertyValue<CHandle<HotkeyRadioStatusListener>>();
			set => SetPropertyValue<CHandle<HotkeyRadioStatusListener>>(value);
		}

		public HotkeyRadioWidgetController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
