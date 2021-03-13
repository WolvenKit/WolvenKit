using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationSummaryListItem : inkListItemController
	{
		[Ordinal(16)] [RED("headerLabel")] public inkTextWidgetReference HeaderLabel { get; set; }
		[Ordinal(17)] [RED("descLabel")] public inkTextWidgetReference DescLabel { get; set; }
		[Ordinal(18)] [RED("data")] public CHandle<CharacterCreationSummaryListItemData> Data { get; set; }

		public characterCreationSummaryListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
