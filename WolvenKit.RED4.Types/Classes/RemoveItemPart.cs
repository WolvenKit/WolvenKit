using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveItemPart : gameScriptableSystemRequest
	{
		private CWeakHandle<gameObject> _obj;
		private gameItemID _baseItem;
		private TweakDBID _slotToEmpty;

		[Ordinal(0)] 
		[RED("obj")] 
		public CWeakHandle<gameObject> Obj
		{
			get => GetProperty(ref _obj);
			set => SetProperty(ref _obj, value);
		}

		[Ordinal(1)] 
		[RED("baseItem")] 
		public gameItemID BaseItem
		{
			get => GetProperty(ref _baseItem);
			set => SetProperty(ref _baseItem, value);
		}

		[Ordinal(2)] 
		[RED("slotToEmpty")] 
		public TweakDBID SlotToEmpty
		{
			get => GetProperty(ref _slotToEmpty);
			set => SetProperty(ref _slotToEmpty, value);
		}
	}
}
