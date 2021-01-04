using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameNotificationsTest : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("token")] public CHandle<inkGameNotificationToken> Token { get; set; }

		public gameNotificationsTest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
