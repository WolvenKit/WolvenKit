using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FindServersMenuGameController : PreGameSubMenuGameController
	{
		[Ordinal(3)] [RED("serversListCtrl")] public wCHandle<inkListController> ServersListCtrl { get; set; }
		[Ordinal(4)] [RED("NONE_CHOOSEN")] public CInt32 NONE_CHOOSEN { get; set; }
		[Ordinal(5)] [RED("curentlyChoosenServer")] public CInt32 CurentlyChoosenServer { get; set; }
		[Ordinal(6)] [RED("LANStatusLabel")] public wCHandle<inkTextWidget> LANStatusLabel { get; set; }
		[Ordinal(7)] [RED("WEBStatusLabel")] public wCHandle<inkTextWidget> WEBStatusLabel { get; set; }
		[Ordinal(8)] [RED("c_onlineColor")] public CColor C_onlineColor { get; set; }
		[Ordinal(9)] [RED("c_offlineColor")] public CColor C_offlineColor { get; set; }
		[Ordinal(10)] [RED("token")] public wCHandle<inkTextWidget> Token { get; set; }

		public FindServersMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
