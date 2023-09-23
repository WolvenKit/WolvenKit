using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SlotMachineSlot : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("winningRowIndex")] 
		public CInt32 WinningRowIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("imagesUpper")] 
		public CArray<inkImageWidgetReference> ImagesUpper
		{
			get => GetPropertyValue<CArray<inkImageWidgetReference>>();
			set => SetPropertyValue<CArray<inkImageWidgetReference>>(value);
		}

		[Ordinal(3)] 
		[RED("imagesLower")] 
		public CArray<inkImageWidgetReference> ImagesLower
		{
			get => GetPropertyValue<CArray<inkImageWidgetReference>>();
			set => SetPropertyValue<CArray<inkImageWidgetReference>>(value);
		}

		[Ordinal(4)] 
		[RED("imagePresets")] 
		public CArray<CName> ImagePresets
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public SlotMachineSlot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
