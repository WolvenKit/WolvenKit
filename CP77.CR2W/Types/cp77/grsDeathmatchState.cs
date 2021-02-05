using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class grsDeathmatchState : CVariable
	{
		[Ordinal(0)]  [RED("time")] public netTime Time { get; set; }
		[Ordinal(1)]  [RED("status")] public CEnum<grsDeathmatchStatus> Status { get; set; }
		[Ordinal(2)]  [RED("sessionLength")] public netTime SessionLength { get; set; }
		[Ordinal(3)]  [RED("playersInfo", 7)] public CStatic<grsDeathmatchPlayerGameInfo> PlayersInfo { get; set; }

		public grsDeathmatchState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
