using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class characterCreationSummaryListItem : inkListItemController
	{
		[Ordinal(0)]  [RED("data")] public CHandle<CharacterCreationSummaryListItemData> Data { get; set; }
		[Ordinal(1)]  [RED("descLabel")] public inkTextWidgetReference DescLabel { get; set; }
		[Ordinal(2)]  [RED("headerLabel")] public inkTextWidgetReference HeaderLabel { get; set; }

		public characterCreationSummaryListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
