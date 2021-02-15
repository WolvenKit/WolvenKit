using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SettingsListItem : inkListItemController
	{
		[Ordinal(16)] [RED("Selector")] public inkWidgetReference Selector { get; set; }
		[Ordinal(17)] [RED("settingsSelector")] public wCHandle<inkSettingsSelectorController> SettingsSelector { get; set; }

		public SettingsListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
