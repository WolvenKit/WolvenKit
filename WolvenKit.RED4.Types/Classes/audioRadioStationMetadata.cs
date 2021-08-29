using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioRadioStationMetadata : audioAudioMetadata
	{
		private CArray<CName> _tracks;
		private CEnum<audioRadioSpeakerType> _speaker;

		[Ordinal(1)] 
		[RED("tracks")] 
		public CArray<CName> Tracks
		{
			get => GetProperty(ref _tracks);
			set => SetProperty(ref _tracks, value);
		}

		[Ordinal(2)] 
		[RED("speaker")] 
		public CEnum<audioRadioSpeakerType> Speaker
		{
			get => GetProperty(ref _speaker);
			set => SetProperty(ref _speaker, value);
		}
	}
}
