using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StackTracksExtender_ : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] [RED("tag")] public CName Tag { get; set; }
		[Ordinal(3)] [RED("newTracks")] public CArray<animFloatTrackInfo> NewTracks { get; set; }

		public animAnimNode_StackTracksExtender_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
