using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioPlaylistTrackEventStruct : CVariable
	{
		[Ordinal(0)]  [RED("playlistName")] public CName PlaylistName { get; set; }
		[Ordinal(1)]  [RED("trackName")] public CName TrackName { get; set; }

		public audioPlaylistTrackEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
