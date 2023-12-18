using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HotkeyCustomRadioWidgetController : gameuiNewPhoneRelatedHUDGameController
	{
		[Ordinal(15)] 
		[RED("radioSlot")] 
		public inkCompoundWidgetReference RadioSlot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("DpadHintLibraryPath")] 
		public inkWidgetLibraryReference DpadHintLibraryPath
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		public HotkeyCustomRadioWidgetController()
		{
			RadioSlot = new inkCompoundWidgetReference();
			DpadHintLibraryPath = new inkWidgetLibraryReference { WidgetLibrary = new inkWidgetLibraryResourceWrapper() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
