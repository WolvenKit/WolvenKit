using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioRadioStationMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("tracks")] 
		public CArray<CName> Tracks
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("blips")] 
		public CArray<audioRadioBlip> Blips
		{
			get => GetPropertyValue<CArray<audioRadioBlip>>();
			set => SetPropertyValue<CArray<audioRadioBlip>>(value);
		}

		[Ordinal(3)] 
		[RED("speaker")] 
		public CEnum<audioRadioSpeakerType> Speaker
		{
			get => GetPropertyValue<CEnum<audioRadioSpeakerType>>();
			set => SetPropertyValue<CEnum<audioRadioSpeakerType>>(value);
		}

		public audioRadioStationMetadata()
		{
			Tracks = new();
			Blips = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
