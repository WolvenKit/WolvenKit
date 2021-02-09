using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RevealNetworkGridOnPulse : redEvent
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("revealSlave")] public CBool RevealSlave { get; set; }
		[Ordinal(2)]  [RED("revealMaster")] public CBool RevealMaster { get; set; }

		public RevealNetworkGridOnPulse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
