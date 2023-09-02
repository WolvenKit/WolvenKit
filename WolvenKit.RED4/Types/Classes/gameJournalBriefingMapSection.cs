using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalBriefingMapSection : gameJournalBriefingBaseSection
	{
		[Ordinal(1)] 
		[RED("mapLocation")] 
		public Vector3 MapLocation
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public gameJournalBriefingMapSection()
		{
			MapLocation = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
