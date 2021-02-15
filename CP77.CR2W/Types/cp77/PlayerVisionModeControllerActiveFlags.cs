using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerActiveFlags : CVariable
	{
		[Ordinal(0)] [RED("kerenzikov")] public CBool Kerenzikov { get; set; }
		[Ordinal(1)] [RED("restrictedScene")] public CBool RestrictedScene { get; set; }
		[Ordinal(2)] [RED("dead")] public CBool Dead { get; set; }
		[Ordinal(3)] [RED("takedown")] public CBool Takedown { get; set; }
		[Ordinal(4)] [RED("deviceTakeover")] public CBool DeviceTakeover { get; set; }
		[Ordinal(5)] [RED("braindanceFPP")] public CBool BraindanceFPP { get; set; }
		[Ordinal(6)] [RED("braindanceActive")] public CBool BraindanceActive { get; set; }
		[Ordinal(7)] [RED("veryHardLanding")] public CBool VeryHardLanding { get; set; }
		[Ordinal(8)] [RED("noScanningRestriction")] public CBool NoScanningRestriction { get; set; }
		[Ordinal(9)] [RED("hasNotCybereye")] public CBool HasNotCybereye { get; set; }
		[Ordinal(10)] [RED("isPhotoMode")] public CBool IsPhotoMode { get; set; }

		public PlayerVisionModeControllerActiveFlags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
