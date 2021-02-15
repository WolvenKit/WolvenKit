using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerBlackboardListenersFunctions : CVariable
	{
		[Ordinal(0)] [RED("kerenzikov")] public CName Kerenzikov { get; set; }
		[Ordinal(1)] [RED("restrictedScene")] public CName RestrictedScene { get; set; }
		[Ordinal(2)] [RED("dead")] public CName Dead { get; set; }
		[Ordinal(3)] [RED("takedown")] public CName Takedown { get; set; }
		[Ordinal(4)] [RED("deviceTakeover")] public CName DeviceTakeover { get; set; }
		[Ordinal(5)] [RED("braindanceFPP")] public CName BraindanceFPP { get; set; }
		[Ordinal(6)] [RED("braindanceActive")] public CName BraindanceActive { get; set; }
		[Ordinal(7)] [RED("veryHardLanding")] public CName VeryHardLanding { get; set; }
		[Ordinal(8)] [RED("noScanningRestriction")] public CName NoScanningRestriction { get; set; }

		public PlayerVisionModeControllerBlackboardListenersFunctions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
