using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorGameItemData : IScriptable
	{
		private CHandle<gameItemData> _gameItemData;
		private gameSItemStack _itemStack;

		[Ordinal(0)] 
		[RED("gameItemData")] 
		public CHandle<gameItemData> GameItemData
		{
			get => GetProperty(ref _gameItemData);
			set => SetProperty(ref _gameItemData, value);
		}

		[Ordinal(1)] 
		[RED("itemStack")] 
		public gameSItemStack ItemStack
		{
			get => GetProperty(ref _itemStack);
			set => SetProperty(ref _itemStack, value);
		}
	}
}
