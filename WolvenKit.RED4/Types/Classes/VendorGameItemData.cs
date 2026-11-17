using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorGameItemData : IScriptable
	{
		[Ordinal(0)] 
		[RED("itemData")] 
		public CHandle<gameItemData> ItemData
		{
			get => GetPropertyValue<CHandle<gameItemData>>();
			set => SetPropertyValue<CHandle<gameItemData>>(value);
		}

		[Ordinal(1)] 
		[RED("itemStack")] 
		public gameSItemStack ItemStack
		{
			get => GetPropertyValue<gameSItemStack>();
			set => SetPropertyValue<gameSItemStack>(value);
		}

		public VendorGameItemData()
		{
			ItemStack = new gameSItemStack();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
