using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuantityPickerPopupData : inkGameNotificationData
	{
		private CInt32 _maxValue;
		private InventoryItemData _gameItemData;
		private CEnum<QuantityPickerActionType> _actionType;
		private wCHandle<gameObject> _vendor;
		private CBool _isBuyback;
		private CBool _sendQuantityChangedEvent;

		[Ordinal(6)] 
		[RED("maxValue")] 
		public CInt32 MaxValue
		{
			get => GetProperty(ref _maxValue);
			set => SetProperty(ref _maxValue, value);
		}

		[Ordinal(7)] 
		[RED("gameItemData")] 
		public InventoryItemData GameItemData
		{
			get => GetProperty(ref _gameItemData);
			set => SetProperty(ref _gameItemData, value);
		}

		[Ordinal(8)] 
		[RED("actionType")] 
		public CEnum<QuantityPickerActionType> ActionType
		{
			get => GetProperty(ref _actionType);
			set => SetProperty(ref _actionType, value);
		}

		[Ordinal(9)] 
		[RED("vendor")] 
		public wCHandle<gameObject> Vendor
		{
			get => GetProperty(ref _vendor);
			set => SetProperty(ref _vendor, value);
		}

		[Ordinal(10)] 
		[RED("isBuyback")] 
		public CBool IsBuyback
		{
			get => GetProperty(ref _isBuyback);
			set => SetProperty(ref _isBuyback, value);
		}

		[Ordinal(11)] 
		[RED("sendQuantityChangedEvent")] 
		public CBool SendQuantityChangedEvent
		{
			get => GetProperty(ref _sendQuantityChangedEvent);
			set => SetProperty(ref _sendQuantityChangedEvent, value);
		}

		public QuantityPickerPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
