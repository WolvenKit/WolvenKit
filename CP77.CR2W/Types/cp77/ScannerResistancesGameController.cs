using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerResistancesGameController : BaseChunkGameController
	{
		[Ordinal(3)]  [RED("physicalResistText")] public inkTextWidgetReference PhysicalResistText { get; set; }
		[Ordinal(4)]  [RED("physicalResistContainer")] public inkCompoundWidgetReference PhysicalResistContainer { get; set; }
		[Ordinal(5)]  [RED("thermalResistText")] public inkTextWidgetReference ThermalResistText { get; set; }
		[Ordinal(6)]  [RED("thermalResistContainer")] public inkCompoundWidgetReference ThermalResistContainer { get; set; }
		[Ordinal(7)]  [RED("chemicalResistText")] public inkTextWidgetReference ChemicalResistText { get; set; }
		[Ordinal(8)]  [RED("chemicalResistContainer")] public inkCompoundWidgetReference ChemicalResistContainer { get; set; }
		[Ordinal(9)]  [RED("electricResistText")] public inkTextWidgetReference ElectricResistText { get; set; }
		[Ordinal(10)]  [RED("electricResistContainer")] public inkCompoundWidgetReference ElectricResistContainer { get; set; }
		[Ordinal(11)]  [RED("hackingResistText")] public inkTextWidgetReference HackingResistText { get; set; }
		[Ordinal(12)]  [RED("hackingResistContainer")] public inkCompoundWidgetReference HackingResistContainer { get; set; }
		[Ordinal(13)]  [RED("physicalWeaknessText")] public inkTextWidgetReference PhysicalWeaknessText { get; set; }
		[Ordinal(14)]  [RED("physicalWeaknessContainer")] public inkCompoundWidgetReference PhysicalWeaknessContainer { get; set; }
		[Ordinal(15)]  [RED("thermalWeaknessText")] public inkTextWidgetReference ThermalWeaknessText { get; set; }
		[Ordinal(16)]  [RED("thermalWeaknessContainer")] public inkCompoundWidgetReference ThermalWeaknessContainer { get; set; }
		[Ordinal(17)]  [RED("chemicalWeaknessText")] public inkTextWidgetReference ChemicalWeaknessText { get; set; }
		[Ordinal(18)]  [RED("chemicalWeaknessContainer")] public inkCompoundWidgetReference ChemicalWeaknessContainer { get; set; }
		[Ordinal(19)]  [RED("electricWeaknessText")] public inkTextWidgetReference ElectricWeaknessText { get; set; }
		[Ordinal(20)]  [RED("electricWeaknessContainer")] public inkCompoundWidgetReference ElectricWeaknessContainer { get; set; }
		[Ordinal(21)]  [RED("hackingWeaknessText")] public inkTextWidgetReference HackingWeaknessText { get; set; }
		[Ordinal(22)]  [RED("hackingWeaknessContainer")] public inkCompoundWidgetReference HackingWeaknessContainer { get; set; }
		[Ordinal(23)]  [RED("leftPanel")] public inkCompoundWidgetReference LeftPanel { get; set; }
		[Ordinal(24)]  [RED("rightPanel")] public inkCompoundWidgetReference RightPanel { get; set; }
		[Ordinal(25)]  [RED("resistancesCallbackID")] public CUInt32 ResistancesCallbackID { get; set; }
		[Ordinal(26)]  [RED("isValidResistances")] public CBool IsValidResistances { get; set; }

		public ScannerResistancesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
