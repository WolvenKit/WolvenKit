using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryWeaponDisplayController : InventoryItemDisplayController
	{
		[Ordinal(0)]  [RED("damageTypeIndicatorImage")] public inkImageWidgetReference DamageTypeIndicatorImage { get; set; }
		[Ordinal(1)]  [RED("dpsArrow")] public inkWidgetReference DpsArrow { get; set; }
		[Ordinal(2)]  [RED("dpsText")] public inkTextWidgetReference DpsText { get; set; }
		[Ordinal(3)]  [RED("dpsValue")] public inkTextWidgetReference DpsValue { get; set; }
		[Ordinal(4)]  [RED("dpsWrapper")] public inkWidgetReference DpsWrapper { get; set; }
		[Ordinal(5)]  [RED("scopeIcon")] public inkWidgetReference ScopeIcon { get; set; }
		[Ordinal(6)]  [RED("silencerIcon")] public inkWidgetReference SilencerIcon { get; set; }
		[Ordinal(7)]  [RED("statsWrapper")] public inkWidgetReference StatsWrapper { get; set; }
		[Ordinal(8)]  [RED("weaponAttachmentsDisplay")] public CArray<wCHandle<InventoryItemPartDisplay>> WeaponAttachmentsDisplay { get; set; }
		[Ordinal(9)]  [RED("weaponSpecyficModsRoot")] public inkCompoundWidgetReference WeaponSpecyficModsRoot { get; set; }

		public InventoryWeaponDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
