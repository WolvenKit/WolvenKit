using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_RagdollControl : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("canRequestInertialization")] public CBool CanRequestInertialization { get; set; }
		[Ordinal(1)]  [RED("inertializationBlendDuration")] public CFloat InertializationBlendDuration { get; set; }
		[Ordinal(2)]  [RED("inputPoseNode")] public animPoseLink InputPoseNode { get; set; }

		public animAnimNode_RagdollControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
