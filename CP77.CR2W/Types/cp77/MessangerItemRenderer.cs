using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MessangerItemRenderer : JournalEntryListItemController
	{
		[Ordinal(1)]  [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(2)]  [RED("container")] public inkWidgetReference Container { get; set; }
		[Ordinal(3)]  [RED("fluffText")] public inkTextWidgetReference FluffText { get; set; }
		[Ordinal(4)]  [RED("stateMessage")] public CName StateMessage { get; set; }
		[Ordinal(5)]  [RED("statePlayerReply")] public CName StatePlayerReply { get; set; }
		[Ordinal(6)]  [RED("imageId")] public TweakDBID ImageId { get; set; }

		public MessangerItemRenderer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
