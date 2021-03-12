using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_OnePoseInput : animAnimNode_Base
	{
		[Ordinal(11)] [RED("inputLink")] public animPoseLink InputLink { get; set; }

		public animAnimNode_OnePoseInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
