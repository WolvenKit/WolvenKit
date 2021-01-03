using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryWeaponItemChooser : InventoryGenericItemChooser
	{
		[Ordinal(0)]  [RED("attachmentsContainer")] public inkWidgetReference AttachmentsContainer { get; set; }
		[Ordinal(1)]  [RED("attachmentsLabel")] public inkTextWidgetReference AttachmentsLabel { get; set; }
		[Ordinal(2)]  [RED("magazineContainer")] public inkCompoundWidgetReference MagazineContainer { get; set; }
		[Ordinal(3)]  [RED("magazineRootContainer")] public inkCompoundWidgetReference MagazineRootContainer { get; set; }
		[Ordinal(4)]  [RED("scopeContainer")] public inkCompoundWidgetReference ScopeContainer { get; set; }
		[Ordinal(5)]  [RED("scopeRootContainer")] public inkCompoundWidgetReference ScopeRootContainer { get; set; }
		[Ordinal(6)]  [RED("silencerContainer")] public inkCompoundWidgetReference SilencerContainer { get; set; }
		[Ordinal(7)]  [RED("silencerRootContainer")] public inkCompoundWidgetReference SilencerRootContainer { get; set; }
		[Ordinal(8)]  [RED("softwareModsContainer")] public inkWidgetReference SoftwareModsContainer { get; set; }
		[Ordinal(9)]  [RED("softwareModsLabel")] public inkTextWidgetReference SoftwareModsLabel { get; set; }
		[Ordinal(10)]  [RED("softwareModsPush")] public inkWidgetReference SoftwareModsPush { get; set; }

		public InventoryWeaponItemChooser(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
