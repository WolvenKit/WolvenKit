using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddItemsEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("items")] 
		public CArray<CWeakHandle<gamedataInventoryItem_Record>> Items
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataInventoryItem_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataInventoryItem_Record>>>(value);
		}

		public AddItemsEffector()
		{
			Items = new();
		}
	}
}
