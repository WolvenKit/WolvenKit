using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_NameplateDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("EntityID")] public gamebbScriptID_Variant EntityID { get; set; }
		[Ordinal(1)] [RED("IsVisible")] public gamebbScriptID_Bool IsVisible { get; set; }
		[Ordinal(2)] [RED("HeightOffset")] public gamebbScriptID_Float HeightOffset { get; set; }
		[Ordinal(3)] [RED("DamageProjection")] public gamebbScriptID_Int32 DamageProjection { get; set; }

		public UI_NameplateDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
