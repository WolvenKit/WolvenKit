using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioPlaylistTrackEventStruct : CVariable
	{
		[Ordinal(0)]  [RED("playlistName")] public CName PlaylistName { get; set; }
		[Ordinal(1)]  [RED("trackName")] public CName TrackName { get; set; }

		public audioPlaylistTrackEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
