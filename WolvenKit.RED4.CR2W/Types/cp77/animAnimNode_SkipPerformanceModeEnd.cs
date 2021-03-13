using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkipPerformanceModeEnd : animAnimNode_Base
	{
		[Ordinal(11)] [RED("inputLink")] public animPoseLink InputLink { get; set; }

		public animAnimNode_SkipPerformanceModeEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
