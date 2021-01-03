using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkipPerformanceModeEnd : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("inputLink")] public animPoseLink InputLink { get; set; }

		public animAnimNode_SkipPerformanceModeEnd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
