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
			get
			{
				if (_selector == null)
				{
					_selector = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "Selector", cr2w, this);
				}
				return _selector;
			}
			set
			{
				if (_selector == value)
				{
					return;
				}
				_selector = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("settingsSelector")] 
		public wCHandle<inkSettingsSelectorController> SettingsSelector
		{
			get
			{
				if (_settingsSelector == null)
				{
					_settingsSelector = (wCHandle<inkSettingsSelectorController>) CR2WTypeManager.Create("whandle:inkSettingsSelectorController", "settingsSelector", cr2w, this);
				}
				return _settingsSelector;
			}
			set
			{
				if (_settingsSelector == value)
				{
					return;
				}
				_settingsSelector = value;
				PropertySet(this);
			}
		}

		public SettingsListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
