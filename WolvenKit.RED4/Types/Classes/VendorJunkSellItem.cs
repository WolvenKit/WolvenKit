using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorJunkSellItem : IScriptable
	{
		[Ordinal(0)] 
		[RED("item")] 
		public CWeakHandle<gameItemData> Item
		{
			get => GetPropertyValue<CWeakHandle<gameItemData>>();
			set => SetPropertyValue<CWeakHandle<gameItemData>>(value);
		}

		[Ordinal(1)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public VendorJunkSellItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
