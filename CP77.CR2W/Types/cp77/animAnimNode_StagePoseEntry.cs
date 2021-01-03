using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StagePoseEntry : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("inputName")] public CName InputName { get; set; }
		[Ordinal(1)]  [RED("parentInput")] public animPoseLink ParentInput { get; set; }

		public animAnimNode_StagePoseEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
