using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_NameplateDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("DamageProjection")] public gamebbScriptID_Int32 DamageProjection { get; set; }
		[Ordinal(1)]  [RED("EntityID")] public gamebbScriptID_Variant EntityID { get; set; }
		[Ordinal(2)]  [RED("HeightOffset")] public gamebbScriptID_Float HeightOffset { get; set; }
		[Ordinal(3)]  [RED("IsVisible")] public gamebbScriptID_Bool IsVisible { get; set; }

		public UI_NameplateDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
