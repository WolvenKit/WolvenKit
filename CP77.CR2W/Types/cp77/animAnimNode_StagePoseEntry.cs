using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StagePoseEntry : animAnimNode_Base
	{
		[Ordinal(1)] [RED("inputName")] public CName InputName { get; set; }
		[Ordinal(2)] [RED("parentInput")] public animPoseLink ParentInput { get; set; }

		public animAnimNode_StagePoseEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
