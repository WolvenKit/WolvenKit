using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectPlacedSpawner : effectSpawner
	{
		private CHandle<effectIPlacementEntries> _placement;

		[Ordinal(0)] 
		[RED("placement")] 
		public CHandle<effectIPlacementEntries> Placement
		{
			get => GetProperty(ref _placement);
			set => SetProperty(ref _placement, value);
		}
	}
}
