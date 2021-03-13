using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlotMachineSlot : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("winningRowIndex")] public CInt32 WinningRowIndex { get; set; }
		[Ordinal(2)] [RED("imagesUpper")] public CArray<inkImageWidgetReference> ImagesUpper { get; set; }
		[Ordinal(3)] [RED("imagesLower")] public CArray<inkImageWidgetReference> ImagesLower { get; set; }
		[Ordinal(4)] [RED("imagePresets")] public CArray<CName> ImagePresets { get; set; }

		public SlotMachineSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
