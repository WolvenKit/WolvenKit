using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StatPoolSpentPrereqListener : BaseStatPoolPrereqListener
	{
		[Ordinal(0)] [RED("state")] public wCHandle<StatPoolSpentPrereqState> State { get; set; }
		[Ordinal(1)] [RED("overallSpentValue")] public CFloat OverallSpentValue { get; set; }

		public StatPoolSpentPrereqListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
