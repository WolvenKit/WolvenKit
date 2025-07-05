using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioPlaylistMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("broadcastChannel")] 
		public CUInt8 BroadcastChannel
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(2)] 
		[RED("tracks")] 
		public CArray<CName> Tracks
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public audioPlaylistMetadata()
		{
			Tracks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
