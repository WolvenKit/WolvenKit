using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class grsDeathmatchState : CVariable
	{
		[Ordinal(0)]  [RED("playersInfo", 7)] public CStatic<grsDeathmatchPlayerGameInfo> PlayersInfo { get; set; }
		[Ordinal(1)]  [RED("sessionLength")] public netTime SessionLength { get; set; }
		[Ordinal(2)]  [RED("status")] public CEnum<grsDeathmatchStatus> Status { get; set; }
		[Ordinal(3)]  [RED("time")] public netTime Time { get; set; }

		public grsDeathmatchState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
