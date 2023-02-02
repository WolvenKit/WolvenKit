using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetInventorySlotInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("itemCategory")] 
		public TweakDBID ItemCategory
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("quantity")] 
		public CUInt32 Quantity
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameMuppetInventorySlotInfo()
		{
			ItemId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
