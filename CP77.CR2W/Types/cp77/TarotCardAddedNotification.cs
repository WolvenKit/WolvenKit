using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TarotCardAddedNotification : GenericNotificationController
	{
		[Ordinal(0)]  [RED("cardImage")] public inkImageWidgetReference CardImage { get; set; }
		[Ordinal(1)]  [RED("cardNameLabel")] public inkTextWidgetReference CardNameLabel { get; set; }

		public TarotCardAddedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
