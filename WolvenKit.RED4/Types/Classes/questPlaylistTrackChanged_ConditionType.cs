using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPlaylistTrackChanged_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("playlistName")] 
		public CName PlaylistName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questPlaylistTrackChanged_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
