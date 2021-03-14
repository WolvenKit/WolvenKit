using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGridController : inkVirtualCompoundController
	{
		[Ordinal(6)] [RED("height")] public CUInt32 Height { get; set; }
		[Ordinal(7)] [RED("width")] public CUInt32 Width { get; set; }
		[Ordinal(8)] [RED("items")] public CArray<inkGridItem> Items { get; set; }
		[Ordinal(9)] [RED("slotSize")] public Vector2 SlotSize { get; set; }
		[Ordinal(10)] [RED("itemTemplates")] public CArray<inkGridItemTemplate> ItemTemplates { get; set; }

		public inkGridController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
