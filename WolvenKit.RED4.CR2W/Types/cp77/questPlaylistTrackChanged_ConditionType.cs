using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPlaylistTrackChanged_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] [RED("playlistName")] public CName PlaylistName { get; set; }

		public questPlaylistTrackChanged_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
