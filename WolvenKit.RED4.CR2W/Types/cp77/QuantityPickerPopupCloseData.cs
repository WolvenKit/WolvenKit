using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuantityPickerPopupCloseData : inkGameNotificationData
	{
		private CInt32 _choosenQuantity;
		private InventoryItemData _itemData;
		private CEnum<QuantityPickerActionType> _actionType;
		private CBool _isBuyback;

		[Ordinal(6)] 
		[RED("choosenQuantity")] 
		public CInt32 ChoosenQuantity
		{
			get => GetProperty(ref _choosenQuantity);
			set => SetProperty(ref _choosenQuantity, value);
		}

		[Ordinal(7)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(8)] 
		[RED("actionType")] 
		public CEnum<QuantityPickerActionType> ActionType
		{
			get => GetProperty(ref _actionType);
			set => SetProperty(ref _actionType, value);
		}

		[Ordinal(9)] 
		[RED("isBuyback")] 
		public CBool IsBuyback
		{
			get => GetProperty(ref _isBuyback);
			set => SetProperty(ref _isBuyback, value);
		}

		public QuantityPickerPopupCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
