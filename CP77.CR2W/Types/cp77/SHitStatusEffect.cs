using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SHitStatusEffect : CVariable
	{
		[Ordinal(0)] [RED("stacks")] public CFloat Stacks { get; set; }
		[Ordinal(1)] [RED("id")] public TweakDBID Id { get; set; }

		public SHitStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
