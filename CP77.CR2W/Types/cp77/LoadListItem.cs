using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LoadListItem : AnimatedListItemController
	{
		[Ordinal(15)]  [RED("imageReplacement")] public inkImageWidgetReference ImageReplacement { get; set; }
		[Ordinal(16)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(17)]  [RED("labelDate")] public inkTextWidgetReference LabelDate { get; set; }
		[Ordinal(18)]  [RED("type")] public inkTextWidgetReference Type { get; set; }
		[Ordinal(19)]  [RED("quest")] public inkTextWidgetReference Quest { get; set; }
		[Ordinal(20)]  [RED("level")] public inkTextWidgetReference Level { get; set; }
		[Ordinal(21)]  [RED("lifepath")] public inkImageWidgetReference Lifepath { get; set; }
		[Ordinal(22)]  [RED("playTime")] public inkTextWidgetReference PlayTime { get; set; }
		[Ordinal(23)]  [RED("characterLevel")] public inkTextWidgetReference CharacterLevel { get; set; }
		[Ordinal(24)]  [RED("characterLevelLabel")] public inkTextWidgetReference CharacterLevelLabel { get; set; }
		[Ordinal(25)]  [RED("emptySlotWrapper")] public inkWidgetReference EmptySlotWrapper { get; set; }
		[Ordinal(26)]  [RED("wrapper")] public inkWidgetReference Wrapper { get; set; }
		[Ordinal(27)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(28)]  [RED("emptySlot")] public CBool EmptySlot { get; set; }
		[Ordinal(29)]  [RED("validSlot")] public CBool ValidSlot { get; set; }
		[Ordinal(30)]  [RED("initialLoadingID")] public CUInt64 InitialLoadingID { get; set; }

		public LoadListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
