using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamePlayer : CVariable
	{
		[Ordinal(0)]  [RED("nickname")] public CString Nickname { get; set; }
		[Ordinal(1)]  [RED("peerID")] public netPeerID PeerID { get; set; }

		public gamePlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
