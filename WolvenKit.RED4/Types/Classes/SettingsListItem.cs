using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingsListItem : inkListItemController
	{
		[Ordinal(16)] 
		[RED("Selector")] 
		public inkWidgetReference Selector
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("settingsSelector")] 
		public CWeakHandle<inkSettingsSelectorController> SettingsSelector
		{
			get => GetPropertyValue<CWeakHandle<inkSettingsSelectorController>>();
			set => SetPropertyValue<CWeakHandle<inkSettingsSelectorController>>(value);
		}

		public SettingsListItem()
		{
			Selector = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
