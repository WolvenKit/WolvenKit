using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class effectPlacedSpawner : effectSpawner
	{
		[Ordinal(0)] 
		[RED("placement")] 
		public CHandle<effectIPlacementEntries> Placement
		{
			get => GetPropertyValue<CHandle<effectIPlacementEntries>>();
			set => SetPropertyValue<CHandle<effectIPlacementEntries>>(value);
		}

		public effectPlacedSpawner()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
