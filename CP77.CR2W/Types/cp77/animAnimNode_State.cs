using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_State : animAnimNode_Container
	{
		[Ordinal(2)] [RED("name")] public CName Name { get; set; }
		[Ordinal(3)] [RED("outTransitionIndices")] public CArray<CInt16> OutTransitionIndices { get; set; }
		[Ordinal(4)] [RED("preventTransitionsInActivationFrame")] public CBool PreventTransitionsInActivationFrame { get; set; }
		[Ordinal(5)] [RED("tags")] public CArray<CName> Tags { get; set; }
		[Ordinal(6)] [RED("requiredQualityDistanceCategory")] public CUInt32 RequiredQualityDistanceCategory { get; set; }

		public animAnimNode_State(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
