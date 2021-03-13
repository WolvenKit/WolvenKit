using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TV : InteractiveDevice
	{
		[Ordinal(93)] [RED("channels")] public CArray<STvChannel> Channels { get; set; }
		[Ordinal(94)] [RED("initialActiveChannel")] public CInt32 InitialActiveChannel { get; set; }
		[Ordinal(95)] [RED("securedText")] public CString SecuredText { get; set; }
		[Ordinal(96)] [RED("isInteractive")] public CBool IsInteractive { get; set; }
		[Ordinal(97)] [RED("muteInterface")] public CBool MuteInterface { get; set; }
		[Ordinal(98)] [RED("useWhiteNoiseFX")] public CBool UseWhiteNoiseFX { get; set; }
		[Ordinal(99)] [RED("isShortGlitchActive")] public CBool IsShortGlitchActive { get; set; }
		[Ordinal(100)] [RED("shortGlitchDelayID")] public gameDelayID ShortGlitchDelayID { get; set; }
		[Ordinal(101)] [RED("isTVMoving")] public CBool IsTVMoving { get; set; }

		public TV(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
