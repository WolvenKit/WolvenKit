using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPlaylistEmitterMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] [RED("receiverType")] public CName ReceiverType { get; set; }
		[Ordinal(2)] [RED("playlistMetadataName")] public CName PlaylistMetadataName { get; set; }

		public audioPlaylistEmitterMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
