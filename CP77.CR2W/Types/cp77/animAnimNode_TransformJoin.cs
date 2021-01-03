using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformJoin : animAnimNode_TransformValue
	{
		[Ordinal(0)]  [RED("input")] public animTransformLink Input { get; set; }

		public animAnimNode_TransformJoin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
