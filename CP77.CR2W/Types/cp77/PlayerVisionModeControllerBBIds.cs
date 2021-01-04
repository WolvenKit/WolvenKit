using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerBBIds : CVariable
	{
		[Ordinal(0)]  [RED("braindanceActive")] public CHandle<gamebbScriptDefinition> BraindanceActive { get; set; }
		[Ordinal(1)]  [RED("braindanceFPP")] public CHandle<gamebbScriptDefinition> BraindanceFPP { get; set; }
		[Ordinal(2)]  [RED("dead")] public CHandle<gamebbScriptDefinition> Dead { get; set; }
		[Ordinal(3)]  [RED("deviceTakeover")] public CHandle<gamebbScriptDefinition> DeviceTakeover { get; set; }
		[Ordinal(4)]  [RED("kerenzikov")] public CHandle<gamebbScriptDefinition> Kerenzikov { get; set; }
		[Ordinal(5)]  [RED("noScanningRestriction")] public CHandle<gamebbScriptDefinition> NoScanningRestriction { get; set; }
		[Ordinal(6)]  [RED("restrictedScene")] public CHandle<gamebbScriptDefinition> RestrictedScene { get; set; }
		[Ordinal(7)]  [RED("takedown")] public CHandle<gamebbScriptDefinition> Takedown { get; set; }
		[Ordinal(8)]  [RED("veryHardLanding")] public CHandle<gamebbScriptDefinition> VeryHardLanding { get; set; }

		public PlayerVisionModeControllerBBIds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
