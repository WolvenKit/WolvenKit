using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameItemChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("itemData")] 
		public CHandle<gameItemData> ItemData
		{
			get => GetPropertyValue<CHandle<gameItemData>>();
			set => SetPropertyValue<CHandle<gameItemData>>(value);
		}

		[Ordinal(2)] 
		[RED("difference")] 
		public CInt32 Difference
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("currentQuantity")] 
		public CInt32 CurrentQuantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameItemChangedEvent()
		{
			ItemID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
