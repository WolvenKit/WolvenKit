using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChangeCasinoTableStateEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("slotUser")] 
		public gameEntityReference SlotUser
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("slot")] 
		public CEnum<CasinoTableSlot> Slot
		{
			get => GetPropertyValue<CEnum<CasinoTableSlot>>();
			set => SetPropertyValue<CEnum<CasinoTableSlot>>(value);
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<CasinoTableState> State
		{
			get => GetPropertyValue<CEnum<CasinoTableState>>();
			set => SetPropertyValue<CEnum<CasinoTableState>>(value);
		}

		[Ordinal(3)] 
		[RED("betData")] 
		public BetData BetData
		{
			get => GetPropertyValue<BetData>();
			set => SetPropertyValue<BetData>(value);
		}

		public ChangeCasinoTableStateEvent()
		{
			SlotUser = new gameEntityReference { Names = new() };
			BetData = new BetData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
