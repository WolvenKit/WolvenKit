using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessangerReplyItemRenderer : JournalEntryListItemController
	{
		[Ordinal(16)] [RED("textRoot")] public inkWidgetReference TextRoot { get; set; }
		[Ordinal(17)] [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(18)] [RED("animSelectionBackground")] public CHandle<inkanimProxy> AnimSelectionBackground { get; set; }
		[Ordinal(19)] [RED("animSelectionText")] public CHandle<inkanimProxy> AnimSelectionText { get; set; }
		[Ordinal(20)] [RED("selectedState")] public CBool SelectedState { get; set; }
		[Ordinal(21)] [RED("animationDuration")] public CFloat AnimationDuration { get; set; }

		public MessangerReplyItemRenderer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
