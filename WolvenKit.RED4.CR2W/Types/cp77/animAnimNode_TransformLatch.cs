using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformLatch : animAnimNode_TransformValue
	{
		[Ordinal(11)] [RED("input")] public animTransformLink Input { get; set; }

		public animAnimNode_TransformLatch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
