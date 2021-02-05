using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CustomQuestNotificationGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(8)]  [RED("desc")] public inkTextWidgetReference Desc { get; set; }
		[Ordinal(9)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(10)]  [RED("fluffHeader")] public inkTextWidgetReference FluffHeader { get; set; }
		[Ordinal(11)]  [RED("root")] public CHandle<inkWidget> Root { get; set; }
		[Ordinal(12)]  [RED("data")] public CHandle<CustomQuestNotificationUserData> Data { get; set; }
		[Ordinal(13)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }

		public CustomQuestNotificationGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
