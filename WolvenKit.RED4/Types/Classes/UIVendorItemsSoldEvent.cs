using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIVendorItemsSoldEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("requestID")] 
		public CInt32 RequestID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("itemsID")] 
		public CArray<gameItemID> ItemsID
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(2)] 
		[RED("quantity")] 
		public CArray<CInt32> Quantity
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		[Ordinal(3)] 
		[RED("piecesPrice")] 
		public CArray<CInt32> PiecesPrice
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		public UIVendorItemsSoldEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
