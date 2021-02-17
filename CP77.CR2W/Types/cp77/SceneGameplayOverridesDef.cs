using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SceneGameplayOverridesDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("AimForced")] public gamebbScriptID_Bool AimForced { get; set; }
		[Ordinal(1)] [RED("SafeForced")] public gamebbScriptID_Bool SafeForced { get; set; }
		[Ordinal(2)] [RED("WeaponLoweringSpeedOverride")] public gamebbScriptID_Float WeaponLoweringSpeedOverride { get; set; }

		public SceneGameplayOverridesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
