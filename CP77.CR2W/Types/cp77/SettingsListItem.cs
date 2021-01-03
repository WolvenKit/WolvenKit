using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SettingsListItem : inkListItemController
	{
		[Ordinal(0)]  [RED("Selector")] public inkWidgetReference Selector { get; set; }
		[Ordinal(1)]  [RED("settingsSelector")] public wCHandle<inkSettingsSelectorController> SettingsSelector { get; set; }

		public SettingsListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
