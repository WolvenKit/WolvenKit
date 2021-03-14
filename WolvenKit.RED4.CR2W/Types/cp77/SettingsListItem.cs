using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsListItem : inkListItemController
	{
		[Ordinal(16)] [RED("Selector")] public inkWidgetReference Selector { get; set; }
		[Ordinal(17)] [RED("settingsSelector")] public wCHandle<inkSettingsSelectorController> SettingsSelector { get; set; }

		public SettingsListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
