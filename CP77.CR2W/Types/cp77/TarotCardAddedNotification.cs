using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TarotCardAddedNotification : GenericNotificationController
	{
		[Ordinal(12)] [RED("cardImage")] public inkImageWidgetReference CardImage { get; set; }
		[Ordinal(13)] [RED("cardNameLabel")] public inkTextWidgetReference CardNameLabel { get; set; }

		public TarotCardAddedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
