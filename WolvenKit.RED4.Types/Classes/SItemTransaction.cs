using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SItemTransaction : RedBaseClass
	{
		private gameSItemStack _itemStack;
		private CInt32 _pricePerItem;

		[Ordinal(0)] 
		[RED("itemStack")] 
		public gameSItemStack ItemStack
		{
			get => GetProperty(ref _itemStack);
			set => SetProperty(ref _itemStack, value);
		}

		[Ordinal(1)] 
		[RED("pricePerItem")] 
		public CInt32 PricePerItem
		{
			get => GetProperty(ref _pricePerItem);
			set => SetProperty(ref _pricePerItem, value);
		}
	}
}
