using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SettingsCategoryItem : inkListItemController
	{
		[Ordinal(16)] [RED("labelHighlight")] public inkTextWidgetReference LabelHighlight { get; set; }

		public SettingsCategoryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
