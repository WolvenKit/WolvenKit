using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioRadioTracksMetadata : audioAudioMetadata
	{
		private CArray<audioRadioTrack> _radioTracks;

		[Ordinal(1)] 
		[RED("radioTracks")] 
		public CArray<audioRadioTrack> RadioTracks
		{
			get => GetProperty(ref _radioTracks);
			set => SetProperty(ref _radioTracks, value);
		}
	}
}
