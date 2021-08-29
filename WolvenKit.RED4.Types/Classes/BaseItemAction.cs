using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseItemAction : BaseScriptableAction
	{
		private CWeakHandle<gameItemData> _itemData;
		private CBool _removeAfterUse;
		private CInt32 _quantity;

		[Ordinal(11)] 
		[RED("itemData")] 
		public CWeakHandle<gameItemData> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(12)] 
		[RED("removeAfterUse")] 
		public CBool RemoveAfterUse
		{
			get => GetProperty(ref _removeAfterUse);
			set => SetProperty(ref _removeAfterUse, value);
		}

		[Ordinal(13)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}
	}
}
