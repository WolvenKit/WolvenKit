using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_State : animAnimNode_Container
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("outTransitionIndices")] public CArray<CInt16> OutTransitionIndices { get; set; }
		[Ordinal(2)]  [RED("preventTransitionsInActivationFrame")] public CBool PreventTransitionsInActivationFrame { get; set; }
		[Ordinal(3)]  [RED("tags")] public CArray<CName> Tags { get; set; }
		[Ordinal(4)]  [RED("requiredQualityDistanceCategory")] public CUInt32 RequiredQualityDistanceCategory { get; set; }

		public animAnimNode_State(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
