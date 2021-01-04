using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_EquipmentDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("EquipmentData")] public gamebbScriptID_Variant EquipmentData { get; set; }
		[Ordinal(1)]  [RED("UIjailbreakData")] public gamebbScriptID_Variant UIjailbreakData { get; set; }
		[Ordinal(2)]  [RED("ammoLooted")] public gamebbScriptID_Bool AmmoLooted { get; set; }

		public UI_EquipmentDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
