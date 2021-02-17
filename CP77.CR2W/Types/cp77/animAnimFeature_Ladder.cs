using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Ladder : animAnimFeature
	{
		[Ordinal(0)] [RED("state")] public CInt32 State { get; set; }
		[Ordinal(1)] [RED("transitionType")] public CInt32 TransitionType { get; set; }
		[Ordinal(2)] [RED("distanceFromTop")] public CFloat DistanceFromTop { get; set; }
		[Ordinal(3)] [RED("entryFromRight")] public CBool EntryFromRight { get; set; }

		public animAnimFeature_Ladder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
