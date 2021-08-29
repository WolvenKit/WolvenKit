using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioPlaylistEmitterMetadata : audioEmitterMetadata
	{
		private CName _receiverType;
		private CName _playlistMetadataName;

		[Ordinal(1)] 
		[RED("receiverType")] 
		public CName ReceiverType
		{
			get => GetProperty(ref _receiverType);
			set => SetProperty(ref _receiverType, value);
		}

		[Ordinal(2)] 
		[RED("playlistMetadataName")] 
		public CName PlaylistMetadataName
		{
			get => GetProperty(ref _playlistMetadataName);
			set => SetProperty(ref _playlistMetadataName, value);
		}
	}
}
