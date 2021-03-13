using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneMessageNotificationsGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("maxMessageSize")] public CInt32 MaxMessageSize { get; set; }
		[Ordinal(3)] [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(4)] [RED("text")] public inkTextWidgetReference Text { get; set; }
		[Ordinal(5)] [RED("actionText")] public inkTextWidgetReference ActionText { get; set; }
		[Ordinal(6)] [RED("actionPanel")] public CHandle<inkWidget> ActionPanel { get; set; }
		[Ordinal(7)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(8)] [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(9)] [RED("data")] public wCHandle<JournalNotificationData> Data { get; set; }

		public PhoneMessageNotificationsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
