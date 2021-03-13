using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SUIScreenDefinition : CVariable
	{
		[Ordinal(0)] [RED("screenDefinition")] public TweakDBID ScreenDefinition { get; set; }
		[Ordinal(1)] [RED("style")] public TweakDBID Style { get; set; }

		public SUIScreenDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
