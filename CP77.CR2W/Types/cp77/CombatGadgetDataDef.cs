using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CombatGadgetDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("lastThrowAngle")] public gamebbScriptID_Float LastThrowAngle { get; set; }
		[Ordinal(1)]  [RED("lastThrowPosition")] public gamebbScriptID_Vector4 LastThrowPosition { get; set; }
		[Ordinal(2)]  [RED("lastThrowStartType")] public gamebbScriptID_Variant LastThrowStartType { get; set; }
		[Ordinal(3)]  [RED("throwUnequip")] public gamebbScriptID_Bool ThrowUnequip { get; set; }

		public CombatGadgetDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
