using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryItemPartDisplay : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("PartIconImage")] public inkImageWidgetReference PartIconImage { get; set; }
		[Ordinal(1)]  [RED("Rarity")] public inkWidgetReference Rarity { get; set; }
		[Ordinal(2)]  [RED("TexturePartName")] public CName TexturePartName { get; set; }
		[Ordinal(3)]  [RED("attachmentData")] public InventoryItemAttachments AttachmentData { get; set; }

		public InventoryItemPartDisplay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
