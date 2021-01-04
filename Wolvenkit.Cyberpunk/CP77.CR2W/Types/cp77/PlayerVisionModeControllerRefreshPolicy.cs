using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerRefreshPolicy : CVariable
	{
		[Ordinal(0)]  [RED("braindanceActive")] public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> BraindanceActive { get; set; }
		[Ordinal(1)]  [RED("braindanceFPP")] public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> BraindanceFPP { get; set; }
		[Ordinal(2)]  [RED("dead")] public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> Dead { get; set; }
		[Ordinal(3)]  [RED("deviceTakeover")] public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> DeviceTakeover { get; set; }
		[Ordinal(4)]  [RED("hasNotCybereye")] public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> HasNotCybereye { get; set; }
		[Ordinal(5)]  [RED("isPhotoMode")] public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> IsPhotoMode { get; set; }
		[Ordinal(6)]  [RED("kerenzikov")] public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> Kerenzikov { get; set; }
		[Ordinal(7)]  [RED("noScanningRestriction")] public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> NoScanningRestriction { get; set; }
		[Ordinal(8)]  [RED("restrictedScene")] public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> RestrictedScene { get; set; }
		[Ordinal(9)]  [RED("takedown")] public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> Takedown { get; set; }
		[Ordinal(10)]  [RED("veryHardLanding")] public CEnum<PlayerVisionModeControllerRefreshPolicyEnum> VeryHardLanding { get; set; }

		public PlayerVisionModeControllerRefreshPolicy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
