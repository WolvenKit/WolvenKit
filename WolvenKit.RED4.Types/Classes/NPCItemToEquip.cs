using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCItemToEquip : RedBaseClass
	{
		private gameItemID _itemID;
		private TweakDBID _slotID;
		private TweakDBID _bodySlotID;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(2)] 
		[RED("bodySlotID")] 
		public TweakDBID BodySlotID
		{
			get => GetProperty(ref _bodySlotID);
			set => SetProperty(ref _bodySlotID, value);
		}
	}
}
