using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlotMachineSlot : inkWidgetLogicController
	{
		private CInt32 _winningRowIndex;
		private CArray<inkImageWidgetReference> _imagesUpper;
		private CArray<inkImageWidgetReference> _imagesLower;
		private CArray<CName> _imagePresets;

		[Ordinal(1)] 
		[RED("winningRowIndex")] 
		public CInt32 WinningRowIndex
		{
			get => GetProperty(ref _winningRowIndex);
			set => SetProperty(ref _winningRowIndex, value);
		}

		[Ordinal(2)] 
		[RED("imagesUpper")] 
		public CArray<inkImageWidgetReference> ImagesUpper
		{
			get => GetProperty(ref _imagesUpper);
			set => SetProperty(ref _imagesUpper, value);
		}

		[Ordinal(3)] 
		[RED("imagesLower")] 
		public CArray<inkImageWidgetReference> ImagesLower
		{
			get => GetProperty(ref _imagesLower);
			set => SetProperty(ref _imagesLower, value);
		}

		[Ordinal(4)] 
		[RED("imagePresets")] 
		public CArray<CName> ImagePresets
		{
			get => GetProperty(ref _imagePresets);
			set => SetProperty(ref _imagePresets, value);
		}

		public SlotMachineSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
