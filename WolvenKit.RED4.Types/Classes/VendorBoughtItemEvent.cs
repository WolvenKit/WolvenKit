using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorBoughtItemEvent : redEvent
	{
		private CArray<gameItemID> _items;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<gameItemID> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}
	}
}
