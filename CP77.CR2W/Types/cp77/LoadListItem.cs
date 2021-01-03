using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LoadListItem : AnimatedListItemController
	{
		[Ordinal(0)]  [RED("characterLevel")] public inkTextWidgetReference CharacterLevel { get; set; }
		[Ordinal(1)]  [RED("characterLevelLabel")] public inkTextWidgetReference CharacterLevelLabel { get; set; }
		[Ordinal(2)]  [RED("emptySlot")] public CBool EmptySlot { get; set; }
		[Ordinal(3)]  [RED("emptySlotWrapper")] public inkWidgetReference EmptySlotWrapper { get; set; }
		[Ordinal(4)]  [RED("imageReplacement")] public inkImageWidgetReference ImageReplacement { get; set; }
		[Ordinal(5)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(6)]  [RED("initialLoadingID")] public CUInt64 InitialLoadingID { get; set; }
		[Ordinal(7)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(8)]  [RED("labelDate")] public inkTextWidgetReference LabelDate { get; set; }
		[Ordinal(9)]  [RED("level")] public inkTextWidgetReference Level { get; set; }
		[Ordinal(10)]  [RED("lifepath")] public inkImageWidgetReference Lifepath { get; set; }
		[Ordinal(11)]  [RED("playTime")] public inkTextWidgetReference PlayTime { get; set; }
		[Ordinal(12)]  [RED("quest")] public inkTextWidgetReference Quest { get; set; }
		[Ordinal(13)]  [RED("type")] public inkTextWidgetReference Type { get; set; }
		[Ordinal(14)]  [RED("validSlot")] public CBool ValidSlot { get; set; }
		[Ordinal(15)]  [RED("wrapper")] public inkWidgetReference Wrapper { get; set; }

		public LoadListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
