using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioPlaylistEmitterMetadata : audioEmitterMetadata
	{
		[Ordinal(0)]  [RED("playlistMetadataName")] public CName PlaylistMetadataName { get; set; }
		[Ordinal(1)]  [RED("receiverType")] public CName ReceiverType { get; set; }

		public audioPlaylistEmitterMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
