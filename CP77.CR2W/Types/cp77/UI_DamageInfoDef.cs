using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_DamageInfoDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("DamageList")] public gamebbScriptID_Variant DamageList { get; set; }
		[Ordinal(1)] [RED("KillList")] public gamebbScriptID_Variant KillList { get; set; }
		[Ordinal(2)] [RED("DigitsMode")] public gamebbScriptID_Variant DigitsMode { get; set; }
		[Ordinal(3)] [RED("DigitsInterpolationOn")] public gamebbScriptID_Bool DigitsInterpolationOn { get; set; }
		[Ordinal(4)] [RED("DigitsStickingMode")] public gamebbScriptID_Variant DigitsStickingMode { get; set; }
		[Ordinal(5)] [RED("HitIndicatorEnabled")] public gamebbScriptID_Bool HitIndicatorEnabled { get; set; }
		[Ordinal(6)] [RED("DmgIndicatorMode")] public gamebbScriptID_Variant DmgIndicatorMode { get; set; }

		public UI_DamageInfoDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
