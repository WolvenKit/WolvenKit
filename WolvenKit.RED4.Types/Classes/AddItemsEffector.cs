using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddItemsEffector : gameEffector
	{
		private CArray<CWeakHandle<gamedataInventoryItem_Record>> _items;

		[Ordinal(0)] 
		[RED("items")] 
		public CArray<CWeakHandle<gamedataInventoryItem_Record>> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}
	}
}
