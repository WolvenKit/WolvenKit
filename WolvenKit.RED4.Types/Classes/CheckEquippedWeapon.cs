using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckEquippedWeapon : AIItemHandlingCondition
	{
		private CHandle<AIArgumentMapping> _slotID;
		private CHandle<AIArgumentMapping> _itemID;
		private TweakDBID _slotIDName;
		private TweakDBID _itemIDName;

		[Ordinal(0)] 
		[RED("slotID")] 
		public CHandle<AIArgumentMapping> SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("itemID")] 
		public CHandle<AIArgumentMapping> ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(2)] 
		[RED("slotIDName")] 
		public TweakDBID SlotIDName
		{
			get => GetProperty(ref _slotIDName);
			set => SetProperty(ref _slotIDName, value);
		}

		[Ordinal(3)] 
		[RED("itemIDName")] 
		public TweakDBID ItemIDName
		{
			get => GetProperty(ref _itemIDName);
			set => SetProperty(ref _itemIDName, value);
		}
	}
}
