using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StackTracksExtender : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("newTracks")] public CArray<animFloatTrackInfo> NewTracks { get; set; }
		[Ordinal(1)]  [RED("tag")] public CName Tag { get; set; }

		public animAnimNode_StackTracksExtender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
