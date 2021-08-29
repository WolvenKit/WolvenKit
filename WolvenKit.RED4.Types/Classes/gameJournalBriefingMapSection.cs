using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalBriefingMapSection : gameJournalBriefingBaseSection
	{
		private Vector3 _mapLocation;

		[Ordinal(1)] 
		[RED("mapLocation")] 
		public Vector3 MapLocation
		{
			get => GetProperty(ref _mapLocation);
			set => SetProperty(ref _mapLocation, value);
		}
	}
}
