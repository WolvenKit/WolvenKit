using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameOccupantSlotComponent : entSlotComponent
	{
		[Ordinal(7)] 
		[RED("slotData")] 
		public CArray<gameOccupantSlotData> SlotData
		{
			get => GetPropertyValue<CArray<gameOccupantSlotData>>();
			set => SetPropertyValue<CArray<gameOccupantSlotData>>(value);
		}

		public gameOccupantSlotComponent()
		{
			SlotData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
