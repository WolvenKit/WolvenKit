using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebugDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("WeaponSpread_EvenDistributionRowCount")] public gamebbScriptID_Int32 WeaponSpread_EvenDistributionRowCount { get; set; }
		[Ordinal(1)] [RED("WeaponSpread_ProjectilesPerShot")] public gamebbScriptID_Int32 WeaponSpread_ProjectilesPerShot { get; set; }
		[Ordinal(2)] [RED("WeaponSpread_UseCircularSpread")] public gamebbScriptID_Bool WeaponSpread_UseCircularSpread { get; set; }
		[Ordinal(3)] [RED("WeaponSpread_UseEvenDistribution")] public gamebbScriptID_Bool WeaponSpread_UseEvenDistribution { get; set; }
		[Ordinal(4)] [RED("Vehicle_BlockSwitchSeats")] public gamebbScriptID_Bool Vehicle_BlockSwitchSeats { get; set; }

		public DebugDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
