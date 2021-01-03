using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerActiveFlags : CVariable
	{
		[Ordinal(0)]  [RED("braindanceActive")] public CBool BraindanceActive { get; set; }
		[Ordinal(1)]  [RED("braindanceFPP")] public CBool BraindanceFPP { get; set; }
		[Ordinal(2)]  [RED("dead")] public CBool Dead { get; set; }
		[Ordinal(3)]  [RED("deviceTakeover")] public CBool DeviceTakeover { get; set; }
		[Ordinal(4)]  [RED("hasNotCybereye")] public CBool HasNotCybereye { get; set; }
		[Ordinal(5)]  [RED("isPhotoMode")] public CBool IsPhotoMode { get; set; }
		[Ordinal(6)]  [RED("kerenzikov")] public CBool Kerenzikov { get; set; }
		[Ordinal(7)]  [RED("noScanningRestriction")] public CBool NoScanningRestriction { get; set; }
		[Ordinal(8)]  [RED("restrictedScene")] public CBool RestrictedScene { get; set; }
		[Ordinal(9)]  [RED("takedown")] public CBool Takedown { get; set; }
		[Ordinal(10)]  [RED("veryHardLanding")] public CBool VeryHardLanding { get; set; }

		public PlayerVisionModeControllerActiveFlags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
