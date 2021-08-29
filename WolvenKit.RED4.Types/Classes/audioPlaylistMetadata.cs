using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioPlaylistMetadata : audioAudioMetadata
	{
		private CUInt8 _broadcastChannel;
		private CArray<CName> _tracks;

		[Ordinal(1)] 
		[RED("broadcastChannel")] 
		public CUInt8 BroadcastChannel
		{
			get => GetProperty(ref _broadcastChannel);
			set => SetProperty(ref _broadcastChannel, value);
		}

		[Ordinal(2)] 
		[RED("tracks")] 
		public CArray<CName> Tracks
		{
			get => GetProperty(ref _tracks);
			set => SetProperty(ref _tracks, value);
		}
	}
}
