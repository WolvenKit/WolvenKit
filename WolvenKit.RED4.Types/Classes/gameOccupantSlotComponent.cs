using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameOccupantSlotComponent : entSlotComponent
	{
		private CArray<gameOccupantSlotData> _slotData;

		[Ordinal(7)] 
		[RED("slotData")] 
		public CArray<gameOccupantSlotData> SlotData
		{
			get => GetProperty(ref _slotData);
			set => SetProperty(ref _slotData, value);
		}
	}
}
