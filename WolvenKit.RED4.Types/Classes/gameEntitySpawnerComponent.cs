using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEntitySpawnerComponent : gameComponent
	{
		[Ordinal(4)] 
		[RED("slotDataArray")] 
		public CArray<gameEntitySpawnerSlotData> SlotDataArray
		{
			get => GetPropertyValue<CArray<gameEntitySpawnerSlotData>>();
			set => SetPropertyValue<CArray<gameEntitySpawnerSlotData>>(value);
		}

		public gameEntitySpawnerComponent()
		{
			SlotDataArray = new();
		}
	}
}
