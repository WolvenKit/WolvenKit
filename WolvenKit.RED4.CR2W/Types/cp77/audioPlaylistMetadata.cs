using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPlaylistMetadata : audioAudioMetadata
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

		public audioPlaylistMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
