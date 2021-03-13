using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FindNavmeshPointAroundThePlayer : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("outPositionArgument")] public CHandle<AIArgumentMapping> OutPositionArgument { get; set; }

		public FindNavmeshPointAroundThePlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
