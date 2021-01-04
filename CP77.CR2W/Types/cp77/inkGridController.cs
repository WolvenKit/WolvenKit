using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkGridController : inkVirtualCompoundController
	{
		[Ordinal(0)]  [RED("height")] public CUInt32 Height { get; set; }
		[Ordinal(1)]  [RED("itemTemplates")] public CArray<inkGridItemTemplate> ItemTemplates { get; set; }
		[Ordinal(2)]  [RED("items")] public CArray<inkGridItem> Items { get; set; }
		[Ordinal(3)]  [RED("slotSize")] public Vector2 SlotSize { get; set; }
		[Ordinal(4)]  [RED("width")] public CUInt32 Width { get; set; }

		public inkGridController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
