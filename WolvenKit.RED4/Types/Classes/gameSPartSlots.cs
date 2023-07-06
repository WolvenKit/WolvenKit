using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSPartSlots : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<gameESlotState> Status
		{
			get => GetPropertyValue<CEnum<gameESlotState>>();
			set => SetPropertyValue<CEnum<gameESlotState>>(value);
		}

		[Ordinal(1)] 
		[RED("installedPart")] 
		public gameItemID InstalledPart
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("innerItemData")] 
		public gameInnerItemData InnerItemData
		{
			get => GetPropertyValue<gameInnerItemData>();
			set => SetPropertyValue<gameInnerItemData>(value);
		}

		public gameSPartSlots()
		{
			InstalledPart = new gameItemID();
			InnerItemData = new gameInnerItemData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
