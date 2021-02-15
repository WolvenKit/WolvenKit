using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldEffect : resStreamedResource
	{
		[Ordinal(1)] [RED("name")] public CName Name { get; set; }
		[Ordinal(2)] [RED("length")] public CFloat Length { get; set; }
		[Ordinal(3)] [RED("inputParameterNames")] public CArray<CName> InputParameterNames { get; set; }
		[Ordinal(4)] [RED("trackRoot")] public CHandle<effectTrackGroup> TrackRoot { get; set; }
		[Ordinal(5)] [RED("events")] public CArray<CHandle<effectTrackItem>> Events { get; set; }
		[Ordinal(6)] [RED("effectLoops")] public CArray<effectLoopData> EffectLoops { get; set; }

		public worldEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
