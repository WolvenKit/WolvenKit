using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Root : animAnimNode_Container
	{
		[Ordinal(12)] [RED("outputNode")] public animPoseLink OutputNode { get; set; }

		public animAnimNode_Root(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
