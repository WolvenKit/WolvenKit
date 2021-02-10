using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SlotMachineSlot : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("winningRowIndex")] public CInt32 WinningRowIndex { get; set; }
		[Ordinal(1)]  [RED("imagesUpper")] public CArray<inkImageWidgetReference> ImagesUpper { get; set; }
		[Ordinal(2)]  [RED("imagesLower")] public CArray<inkImageWidgetReference> ImagesLower { get; set; }
		[Ordinal(3)]  [RED("imagePresets")] public CArray<CName> ImagePresets { get; set; }

		public SlotMachineSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
