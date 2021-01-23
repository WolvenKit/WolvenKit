using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_OnePoseInput : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("inputLink")] public animPoseLink InputLink { get; set; }
		[Ordinal(1)]  [RED("VisMask", 0, 0)] public CArray<animTransformIndex> VisMask { get; set; }
		[Ordinal(2)]  [RED("VisAxes", 0, 0)] public CBool VisAxes { get; set; }
		[Ordinal(3)]  [RED("VisNames", 0, 0)] public CBool VisNames { get; set; }

		public animAnimNode_OnePoseInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
