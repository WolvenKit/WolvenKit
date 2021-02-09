using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class characterCreationSummaryListItem : inkListItemController
	{
		[Ordinal(1)]  [RED("headerLabel")] public inkTextWidgetReference HeaderLabel { get; set; }
		[Ordinal(2)]  [RED("descLabel")] public inkTextWidgetReference DescLabel { get; set; }
		[Ordinal(3)]  [RED("data")] public CHandle<CharacterCreationSummaryListItemData> Data { get; set; }

		public characterCreationSummaryListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
