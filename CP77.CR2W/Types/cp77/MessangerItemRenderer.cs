using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class MessangerItemRenderer : JournalEntryListItemController
	{
		[Ordinal(0)]  [RED("container")] public inkWidgetReference Container { get; set; }
		[Ordinal(1)]  [RED("fluffText")] public inkTextWidgetReference FluffText { get; set; }
		[Ordinal(2)]  [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(3)]  [RED("imageId")] public TweakDBID ImageId { get; set; }
		[Ordinal(4)]  [RED("stateMessage")] public CName StateMessage { get; set; }
		[Ordinal(5)]  [RED("statePlayerReply")] public CName StatePlayerReply { get; set; }

		public MessangerItemRenderer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
