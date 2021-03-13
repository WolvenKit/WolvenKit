using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerBBValuesIds : CVariable
	{
		[Ordinal(0)] [RED("kerenzikov")] public gamebbScriptID_Int32 Kerenzikov { get; set; }
		[Ordinal(1)] [RED("restrictedScene")] public gamebbScriptID_Int32 RestrictedScene { get; set; }
		[Ordinal(2)] [RED("dead")] public gamebbScriptID_Int32 Dead { get; set; }
		[Ordinal(3)] [RED("takedown")] public gamebbScriptID_Int32 Takedown { get; set; }
		[Ordinal(4)] [RED("deviceTakeover")] public gamebbScriptID_EntityID DeviceTakeover { get; set; }
		[Ordinal(5)] [RED("braindanceFPP")] public gamebbScriptID_Bool BraindanceFPP { get; set; }
		[Ordinal(6)] [RED("braindanceActive")] public gamebbScriptID_Bool BraindanceActive { get; set; }
		[Ordinal(7)] [RED("veryHardLanding")] public gamebbScriptID_Int32 VeryHardLanding { get; set; }
		[Ordinal(8)] [RED("noScanningRestriction")] public gamebbScriptID_Variant NoScanningRestriction { get; set; }

		public PlayerVisionModeControllerBBValuesIds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
