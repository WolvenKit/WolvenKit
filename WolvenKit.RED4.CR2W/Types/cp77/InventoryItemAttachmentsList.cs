using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemAttachmentsList : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("libraryItemName")] public CName LibraryItemName { get; set; }
		[Ordinal(2)] [RED("container")] public inkCompoundWidgetReference Container { get; set; }
		[Ordinal(3)] [RED("itemsList")] public CArray<wCHandle<inkWidget>> ItemsList { get; set; }
		[Ordinal(4)] [RED("data")] public CArray<CName> Data { get; set; }

		public InventoryItemAttachmentsList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
