using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SettingsCategoryItem : inkListItemController
	{
		[Ordinal(0)]  [RED("labelHighlight")] public inkTextWidgetReference LabelHighlight { get; set; }

		public SettingsCategoryItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
