using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioPlaylistEmitterMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] 
		[RED("receiverType")] 
		public CName ReceiverType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("playlistMetadataName")] 
		public CName PlaylistMetadataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
