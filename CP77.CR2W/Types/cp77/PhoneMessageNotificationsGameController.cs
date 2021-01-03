using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PhoneMessageNotificationsGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("actionPanel")] public CHandle<inkWidget> ActionPanel { get; set; }
		[Ordinal(1)]  [RED("actionText")] public inkTextWidgetReference ActionText { get; set; }
		[Ordinal(2)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(3)]  [RED("data")] public wCHandle<JournalNotificationData> Data { get; set; }
		[Ordinal(4)]  [RED("maxMessageSize")] public CInt32 MaxMessageSize { get; set; }
		[Ordinal(5)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(6)]  [RED("text")] public inkTextWidgetReference Text { get; set; }
		[Ordinal(7)]  [RED("title")] public inkTextWidgetReference Title { get; set; }

		public PhoneMessageNotificationsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
