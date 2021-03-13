using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatJoin : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("input")] public animFloatLink Input { get; set; }

		public animAnimNode_FloatJoin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
