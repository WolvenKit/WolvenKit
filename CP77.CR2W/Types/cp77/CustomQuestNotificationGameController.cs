using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CustomQuestNotificationGameController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(10)] [RED("desc")] public inkTextWidgetReference Desc { get; set; }
		[Ordinal(11)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(12)] [RED("fluffHeader")] public inkTextWidgetReference FluffHeader { get; set; }
		[Ordinal(13)] [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(14)] [RED("data")] public CHandle<CustomQuestNotificationUserData> Data { get; set; }
		[Ordinal(15)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }

		public CustomQuestNotificationGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
