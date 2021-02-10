using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TV : InteractiveDevice
	{
		[Ordinal(84)]  [RED("channels")] public CArray<STvChannel> Channels { get; set; }
		[Ordinal(85)]  [RED("initialActiveChannel")] public CInt32 InitialActiveChannel { get; set; }
		[Ordinal(86)]  [RED("securedText")] public CString SecuredText { get; set; }
		[Ordinal(87)]  [RED("isInteractive")] public CBool IsInteractive { get; set; }
		[Ordinal(88)]  [RED("muteInterface")] public CBool MuteInterface { get; set; }
		[Ordinal(89)]  [RED("useWhiteNoiseFX")] public CBool UseWhiteNoiseFX { get; set; }
		[Ordinal(90)]  [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(91)]  [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }
		[Ordinal(92)]  [RED("isTVMoving")] public CBool IsTVMoving { get; set; }

		public TV(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
