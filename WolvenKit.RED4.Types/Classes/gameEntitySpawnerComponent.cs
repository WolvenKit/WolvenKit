using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEntitySpawnerComponent : gameComponent
	{
		private CArray<gameEntitySpawnerSlotData> _slotDataArray;

		[Ordinal(4)] 
		[RED("slotDataArray")] 
		public CArray<gameEntitySpawnerSlotData> SlotDataArray
		{
			get => GetProperty(ref _slotDataArray);
			set => SetProperty(ref _slotDataArray, value);
		}
	}
}
