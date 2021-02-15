using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TVResaveData : CVariable
	{
		[Ordinal(0)] [RED("mediaResaveData")] public MediaResaveData MediaResaveData { get; set; }
		[Ordinal(1)] [RED("channels")] public CArray<STvChannel> Channels { get; set; }
		[Ordinal(2)] [RED("securedText")] public CName SecuredText { get; set; }
		[Ordinal(3)] [RED("muteInterface")] public CBool MuteInterface { get; set; }
		[Ordinal(4)] [RED("useWhiteNoiseFX")] public CBool UseWhiteNoiseFX { get; set; }

		public TVResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
