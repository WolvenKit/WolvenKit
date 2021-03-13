using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsDeathParamsEvent : redEvent
	{
		[Ordinal(0)] [RED("noAnimation")] public CBool NoAnimation { get; set; }
		[Ordinal(1)] [RED("noRagdoll")] public CBool NoRagdoll { get; set; }

		public gameeventsDeathParamsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
