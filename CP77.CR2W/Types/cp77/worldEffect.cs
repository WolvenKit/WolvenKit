using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldEffect : resStreamedResource
	{
		[Ordinal(0)]  [RED("effectLoops")] public CArray<effectLoopData> EffectLoops { get; set; }
		[Ordinal(1)]  [RED("events")] public CArray<CHandle<effectTrackItem>> Events { get; set; }
		[Ordinal(2)]  [RED("inputParameterNames")] public CArray<CName> InputParameterNames { get; set; }
		[Ordinal(3)]  [RED("length")] public CFloat Length { get; set; }
		[Ordinal(4)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(5)]  [RED("trackRoot")] public CHandle<effectTrackGroup> TrackRoot { get; set; }

		public worldEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
