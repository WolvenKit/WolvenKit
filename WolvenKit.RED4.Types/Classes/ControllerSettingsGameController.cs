using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ControllerSettingsGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		public ControllerSettingsGameController()
		{
			ButtonHintsManagerRef = new();
		}
	}
}
