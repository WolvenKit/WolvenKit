using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatInput_ : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("group")] public CName Group { get; set; }
		[Ordinal(12)] [RED("name")] public CName Name { get; set; }

		public animAnimNode_FloatInput_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
