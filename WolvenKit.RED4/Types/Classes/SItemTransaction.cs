using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SItemTransaction : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("itemStack")] 
		public gameSItemStack ItemStack
		{
			get => GetPropertyValue<gameSItemStack>();
			set => SetPropertyValue<gameSItemStack>(value);
		}

		[Ordinal(1)] 
		[RED("pricePerItem")] 
		public CInt32 PricePerItem
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SItemTransaction()
		{
			ItemStack = new() { ItemID = new(), Quantity = 1, IsAvailable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, DynamicTags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
