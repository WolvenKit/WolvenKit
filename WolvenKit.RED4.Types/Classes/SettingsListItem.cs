using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SettingsListItem : inkListItemController
	{
		private inkWidgetReference _selector;
		private CWeakHandle<inkSettingsSelectorController> _settingsSelector;

		[Ordinal(16)] 
		[RED("Selector")] 
		public inkWidgetReference Selector
		{
			get => GetProperty(ref _selector);
			set => SetProperty(ref _selector, value);
		}

		[Ordinal(17)] 
		[RED("settingsSelector")] 
		public CWeakHandle<inkSettingsSelectorController> SettingsSelector
		{
			get => GetProperty(ref _settingsSelector);
			set => SetProperty(ref _settingsSelector, value);
		}
	}
}
