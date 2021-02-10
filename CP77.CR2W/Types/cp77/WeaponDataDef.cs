using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WeaponDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("Charge")] public gamebbScriptID_Float Charge { get; set; }
		[Ordinal(1)]  [RED("OverheatPercentage")] public gamebbScriptID_Float OverheatPercentage { get; set; }
		[Ordinal(2)]  [RED("IsInForcedOverheatCooldown")] public gamebbScriptID_Bool IsInForcedOverheatCooldown { get; set; }
		[Ordinal(3)]  [RED("ChargeStep")] public gamebbScriptID_Variant ChargeStep { get; set; }
		[Ordinal(4)]  [RED("TriggerMode")] public gamebbScriptID_Variant TriggerMode { get; set; }
		[Ordinal(5)]  [RED("MagazineAmmoCapacity")] public gamebbScriptID_Uint32 MagazineAmmoCapacity { get; set; }
		[Ordinal(6)]  [RED("MagazineAmmoCount")] public gamebbScriptID_Uint32 MagazineAmmoCount { get; set; }
		[Ordinal(7)]  [RED("MagazineAmmoID")] public gamebbScriptID_Variant MagazineAmmoID { get; set; }

		public WeaponDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
