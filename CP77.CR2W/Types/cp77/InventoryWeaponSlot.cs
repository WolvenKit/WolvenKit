using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryWeaponSlot : InventoryEquipmentSlot
	{
		[Ordinal(17)] [RED("DamageIndicatorRef")] public inkWidgetReference DamageIndicatorRef { get; set; }
		[Ordinal(18)] [RED("DPSRef")] public inkWidgetReference DPSRef { get; set; }
		[Ordinal(19)] [RED("DPSValueLabel")] public inkTextWidgetReference DPSValueLabel { get; set; }
		[Ordinal(20)] [RED("DamageTypeIndicator")] public wCHandle<DamageTypeIndicator> DamageTypeIndicator { get; set; }
		[Ordinal(21)] [RED("IntroPlayed")] public CBool IntroPlayed { get; set; }

		public InventoryWeaponSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
