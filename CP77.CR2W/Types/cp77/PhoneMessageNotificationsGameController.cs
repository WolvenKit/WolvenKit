using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PhoneMessageNotificationsGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("maxMessageSize")] public CInt32 MaxMessageSize { get; set; }
		[Ordinal(1)]  [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(2)]  [RED("text")] public inkTextWidgetReference Text { get; set; }
		[Ordinal(3)]  [RED("actionText")] public inkTextWidgetReference ActionText { get; set; }
		[Ordinal(4)]  [RED("actionPanel")] public CHandle<inkWidget> ActionPanel { get; set; }
		[Ordinal(5)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(6)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(7)]  [RED("data")] public wCHandle<JournalNotificationData> Data { get; set; }

		public PhoneMessageNotificationsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
