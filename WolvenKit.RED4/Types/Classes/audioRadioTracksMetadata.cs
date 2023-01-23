using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioRadioTracksMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("radioTracks")] 
		public CArray<audioRadioTrack> RadioTracks
		{
			get => GetPropertyValue<CArray<audioRadioTrack>>();
			set => SetPropertyValue<CArray<audioRadioTrack>>(value);
		}

		public audioRadioTracksMetadata()
		{
			RadioTracks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
