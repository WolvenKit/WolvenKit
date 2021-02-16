using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePlayer : CVariable
	{
		[Ordinal(0)] [RED("peerID")] public netPeerID PeerID { get; set; }
		[Ordinal(1)] [RED("nickname")] public CString Nickname { get; set; }

		public gamePlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
