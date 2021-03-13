using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryWeaponItemChooser : InventoryGenericItemChooser
	{
		[Ordinal(13)] [RED("scopeRootContainer")] public inkCompoundWidgetReference ScopeRootContainer { get; set; }
		[Ordinal(14)] [RED("magazineRootContainer")] public inkCompoundWidgetReference MagazineRootContainer { get; set; }
		[Ordinal(15)] [RED("silencerRootContainer")] public inkCompoundWidgetReference SilencerRootContainer { get; set; }
		[Ordinal(16)] [RED("scopeContainer")] public inkCompoundWidgetReference ScopeContainer { get; set; }
		[Ordinal(17)] [RED("magazineContainer")] public inkCompoundWidgetReference MagazineContainer { get; set; }
		[Ordinal(18)] [RED("silencerContainer")] public inkCompoundWidgetReference SilencerContainer { get; set; }
		[Ordinal(19)] [RED("attachmentsLabel")] public inkTextWidgetReference AttachmentsLabel { get; set; }
		[Ordinal(20)] [RED("attachmentsContainer")] public inkWidgetReference AttachmentsContainer { get; set; }
		[Ordinal(21)] [RED("softwareModsLabel")] public inkTextWidgetReference SoftwareModsLabel { get; set; }
		[Ordinal(22)] [RED("softwareModsPush")] public inkWidgetReference SoftwareModsPush { get; set; }
		[Ordinal(23)] [RED("softwareModsContainer")] public inkWidgetReference SoftwareModsContainer { get; set; }

		public InventoryWeaponItemChooser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
