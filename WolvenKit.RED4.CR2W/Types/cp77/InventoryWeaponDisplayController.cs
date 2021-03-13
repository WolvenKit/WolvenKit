using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryWeaponDisplayController : InventoryItemDisplayController
	{
		[Ordinal(78)] [RED("weaponSpecyficModsRoot")] public inkCompoundWidgetReference WeaponSpecyficModsRoot { get; set; }
		[Ordinal(79)] [RED("statsWrapper")] public inkWidgetReference StatsWrapper { get; set; }
		[Ordinal(80)] [RED("dpsText")] public inkTextWidgetReference DpsText { get; set; }
		[Ordinal(81)] [RED("damageTypeIndicatorImage")] public inkImageWidgetReference DamageTypeIndicatorImage { get; set; }
		[Ordinal(82)] [RED("dpsWrapper")] public inkWidgetReference DpsWrapper { get; set; }
		[Ordinal(83)] [RED("dpsValue")] public inkTextWidgetReference DpsValue { get; set; }
		[Ordinal(84)] [RED("silencerIcon")] public inkWidgetReference SilencerIcon { get; set; }
		[Ordinal(85)] [RED("scopeIcon")] public inkWidgetReference ScopeIcon { get; set; }
		[Ordinal(86)] [RED("dpsArrow")] public inkWidgetReference DpsArrow { get; set; }
		[Ordinal(87)] [RED("weaponAttachmentsDisplay")] public CArray<wCHandle<InventoryItemPartDisplay>> WeaponAttachmentsDisplay { get; set; }

		public InventoryWeaponDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
