using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_GraphSlot : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("dontDeactivateInput")] public CBool DontDeactivateInput { get; set; }
		[Ordinal(1)]  [RED("inputLink")] public animPoseLink InputLink { get; set; }
		[Ordinal(2)]  [RED("name")] public CName Name { get; set; }

		public animAnimNode_GraphSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
