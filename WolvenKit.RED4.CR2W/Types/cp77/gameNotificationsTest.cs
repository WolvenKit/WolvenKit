using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNotificationsTest : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("token")] public CHandle<inkGameNotificationToken> Token { get; set; }

		public gameNotificationsTest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
