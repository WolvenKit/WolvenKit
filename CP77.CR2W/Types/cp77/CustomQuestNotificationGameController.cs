using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CustomQuestNotificationGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(1)]  [RED("data")] public CHandle<CustomQuestNotificationUserData> Data { get; set; }
		[Ordinal(2)]  [RED("desc")] public inkTextWidgetReference Desc { get; set; }
		[Ordinal(3)]  [RED("fluffHeader")] public inkTextWidgetReference FluffHeader { get; set; }
		[Ordinal(4)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(5)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(6)]  [RED("root")] public CHandle<inkWidget> Root { get; set; }

		public CustomQuestNotificationGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
