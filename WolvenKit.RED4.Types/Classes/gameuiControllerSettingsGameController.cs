using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiControllerSettingsGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("defaultWidgets")] 
		public CArray<inkWidgetReference> DefaultWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(4)] 
		[RED("southpawWidgets")] 
		public CArray<inkWidgetReference> SouthpawWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(5)] 
		[RED("legacyWidgets")] 
		public CArray<inkWidgetReference> LegacyWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(6)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		public gameuiControllerSettingsGameController()
		{
			DefaultWidgets = new();
			SouthpawWidgets = new();
			LegacyWidgets = new();
			ButtonHintsManagerRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
