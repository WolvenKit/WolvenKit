using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerBBListeners : CVariable
	{
		[Ordinal(0)] [RED("kerenzikov")] public CUInt32 Kerenzikov { get; set; }
		[Ordinal(1)] [RED("restrictedScene")] public CUInt32 RestrictedScene { get; set; }
		[Ordinal(2)] [RED("dead")] public CUInt32 Dead { get; set; }
		[Ordinal(3)] [RED("takedown")] public CUInt32 Takedown { get; set; }
		[Ordinal(4)] [RED("deviceTakeover")] public CUInt32 DeviceTakeover { get; set; }
		[Ordinal(5)] [RED("braindanceFPP")] public CUInt32 BraindanceFPP { get; set; }
		[Ordinal(6)] [RED("braindanceActive")] public CUInt32 BraindanceActive { get; set; }
		[Ordinal(7)] [RED("veryHardLanding")] public CUInt32 VeryHardLanding { get; set; }
		[Ordinal(8)] [RED("noScanningRestriction")] public CUInt32 NoScanningRestriction { get; set; }

		public PlayerVisionModeControllerBBListeners(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
