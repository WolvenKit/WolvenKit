using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TarotCardAddedNotification : GenericNotificationController
	{
		[Ordinal(12)] [RED("cardImage")] public inkImageWidgetReference CardImage { get; set; }
		[Ordinal(13)] [RED("cardNameLabel")] public inkTextWidgetReference CardNameLabel { get; set; }

		public TarotCardAddedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
