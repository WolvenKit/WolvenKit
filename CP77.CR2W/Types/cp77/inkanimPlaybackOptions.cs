using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkanimPlaybackOptions : CVariable
	{
		[Ordinal(0)]  [RED("dependsOnTimeDilation")] public CBool DependsOnTimeDilation { get; set; }
		[Ordinal(1)]  [RED("executionDelay")] public CFloat ExecutionDelay { get; set; }
		[Ordinal(2)]  [RED("fromMarker")] public CName FromMarker { get; set; }
		[Ordinal(3)]  [RED("loopCounter")] public CUInt32 LoopCounter { get; set; }
		[Ordinal(4)]  [RED("loopInfinite")] public CBool LoopInfinite { get; set; }
		[Ordinal(5)]  [RED("loopType")] public CEnum<inkanimLoopType> LoopType { get; set; }
		[Ordinal(6)]  [RED("oneSegment")] public CBool OneSegment { get; set; }
		[Ordinal(7)]  [RED("playReversed")] public CBool PlayReversed { get; set; }
		[Ordinal(8)]  [RED("toMarker")] public CName ToMarker { get; set; }

		public inkanimPlaybackOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
