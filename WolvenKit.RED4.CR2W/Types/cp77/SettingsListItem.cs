using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsListItem : inkListItemController
	{
		private inkWidgetReference _selector;
		private wCHandle<inkSettingsSelectorController> _settingsSelector;

		[Ordinal(16)] 
		[RED("Selector")] 
		public inkWidgetReference Selector
		{
			get => GetProperty(ref _selector);
			set => SetProperty(ref _selector, value);
		}

		[Ordinal(17)] 
		[RED("settingsSelector")] 
		public wCHandle<inkSettingsSelectorController> SettingsSelector
		{
			get => GetProperty(ref _settingsSelector);
			set => SetProperty(ref _settingsSelector, value);
		}

		public SettingsListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
