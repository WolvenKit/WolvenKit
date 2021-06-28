using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPlaylistEmitterMetadata : audioEmitterMetadata
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

		public audioPlaylistEmitterMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
