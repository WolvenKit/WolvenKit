using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TV : InteractiveDevice
	{
		[Ordinal(0)]  [RED("channels")] public CArray<STvChannel> Channels { get; set; }
		[Ordinal(1)]  [RED("initialActiveChannel")] public CInt32 InitialActiveChannel { get; set; }
		[Ordinal(2)]  [RED("isInteractive")] public CBool IsInteractive { get; set; }
		[Ordinal(3)]  [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(4)]  [RED("isTVMoving")] public CBool IsTVMoving { get; set; }
		[Ordinal(5)]  [RED("muteInterface")] public CBool MuteInterface { get; set; }
		[Ordinal(6)]  [RED("securedText")] public CString SecuredText { get; set; }
		[Ordinal(7)]  [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }
		[Ordinal(8)]  [RED("useWhiteNoiseFX")] public CBool UseWhiteNoiseFX { get; set; }

		public TV(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
