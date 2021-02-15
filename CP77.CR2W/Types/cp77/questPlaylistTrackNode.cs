using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPlaylistTrackNode : questIAudioNodeType
	{
		[Ordinal(0)] [RED("playlistEvents")] public CArray<audioPlaylistTrackEventStruct> PlaylistEvents { get; set; }

		public questPlaylistTrackNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
