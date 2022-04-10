using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
