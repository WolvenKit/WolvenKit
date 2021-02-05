using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_PlayerStatsDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("MaxHealth")] public gamebbScriptID_Int32 MaxHealth { get; set; }
		[Ordinal(1)]  [RED("CurrentHealth")] public gamebbScriptID_Int32 CurrentHealth { get; set; }
		[Ordinal(2)]  [RED("PhysicalResistance")] public gamebbScriptID_Int32 PhysicalResistance { get; set; }
		[Ordinal(3)]  [RED("ThermalResistance")] public gamebbScriptID_Int32 ThermalResistance { get; set; }
		[Ordinal(4)]  [RED("EnergyResistance")] public gamebbScriptID_Int32 EnergyResistance { get; set; }
		[Ordinal(5)]  [RED("ChemicalResistance")] public gamebbScriptID_Int32 ChemicalResistance { get; set; }
		[Ordinal(6)]  [RED("Level")] public gamebbScriptID_Int32 Level { get; set; }
		[Ordinal(7)]  [RED("CurrentXP")] public gamebbScriptID_Int32 CurrentXP { get; set; }
		[Ordinal(8)]  [RED("StreetCredLevel")] public gamebbScriptID_Int32 StreetCredLevel { get; set; }
		[Ordinal(9)]  [RED("StreetCredPoints")] public gamebbScriptID_Int32 StreetCredPoints { get; set; }
		[Ordinal(10)]  [RED("Attributes")] public gamebbScriptID_Variant Attributes { get; set; }
		[Ordinal(11)]  [RED("DevelopmentPoints")] public gamebbScriptID_Variant DevelopmentPoints { get; set; }
		[Ordinal(12)]  [RED("Proficiency")] public gamebbScriptID_Variant Proficiency { get; set; }
		[Ordinal(13)]  [RED("Perks")] public gamebbScriptID_Variant Perks { get; set; }
		[Ordinal(14)]  [RED("ModifiedPerkArea")] public gamebbScriptID_Variant ModifiedPerkArea { get; set; }
		[Ordinal(15)]  [RED("weightMax")] public gamebbScriptID_Int32 WeightMax { get; set; }
		[Ordinal(16)]  [RED("currentInventoryWeight")] public gamebbScriptID_Float CurrentInventoryWeight { get; set; }
		[Ordinal(17)]  [RED("isReplacer")] public gamebbScriptID_Bool IsReplacer { get; set; }

		public UI_PlayerStatsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
