using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Stage : animAnimNode_Container
	{
		[Ordinal(12)] [RED("inputPoses")] public CArray<animPoseLink> InputPoses { get; set; }

		public animAnimNode_Stage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
