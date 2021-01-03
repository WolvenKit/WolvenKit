using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TVSetup : CVariable
	{
		[Ordinal(0)]  [RED("channels")] public CArray<STvChannel> Channels { get; set; }
		[Ordinal(1)]  [RED("initialChannel")] public CInt32 InitialChannel { get; set; }
		[Ordinal(2)]  [RED("initialGlobalTvChannel")] public TweakDBID InitialGlobalTvChannel { get; set; }
		[Ordinal(3)]  [RED("isGlobalTvOnly")] public CBool IsGlobalTvOnly { get; set; }
		[Ordinal(4)]  [RED("isInteractive")] public CBool IsInteractive { get; set; }
		[Ordinal(5)]  [RED("muteInterface")] public CBool MuteInterface { get; set; }

		public TVSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
