using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorJunkSellItem : IScriptable
	{
		private CWeakHandle<gameItemData> _item;
		private CInt32 _quantity;

		[Ordinal(0)] 
		[RED("item")] 
		public CWeakHandle<gameItemData> Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(1)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}
	}
}
