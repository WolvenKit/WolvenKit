using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LoadListItem : AnimatedListItemController
	{
		[Ordinal(30)] [RED("imageReplacement")] public inkImageWidgetReference ImageReplacement { get; set; }
		[Ordinal(31)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(32)] [RED("labelDate")] public inkTextWidgetReference LabelDate { get; set; }
		[Ordinal(33)] [RED("type")] public inkTextWidgetReference Type { get; set; }
		[Ordinal(34)] [RED("quest")] public inkTextWidgetReference Quest { get; set; }
		[Ordinal(35)] [RED("level")] public inkTextWidgetReference Level { get; set; }
		[Ordinal(36)] [RED("lifepath")] public inkImageWidgetReference Lifepath { get; set; }
		[Ordinal(37)] [RED("playTime")] public inkTextWidgetReference PlayTime { get; set; }
		[Ordinal(38)] [RED("characterLevel")] public inkTextWidgetReference CharacterLevel { get; set; }
		[Ordinal(39)] [RED("characterLevelLabel")] public inkTextWidgetReference CharacterLevelLabel { get; set; }
		[Ordinal(40)] [RED("emptySlotWrapper")] public inkWidgetReference EmptySlotWrapper { get; set; }
		[Ordinal(41)] [RED("wrapper")] public inkWidgetReference Wrapper { get; set; }
		[Ordinal(42)] [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(43)] [RED("emptySlot")] public CBool EmptySlot { get; set; }
		[Ordinal(44)] [RED("validSlot")] public CBool ValidSlot { get; set; }
		[Ordinal(45)] [RED("initialLoadingID")] public CUInt64 InitialLoadingID { get; set; }

		public LoadListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
