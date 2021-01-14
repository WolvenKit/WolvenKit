using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PassiveGlobalDeathCondition : AIbehaviorexpressionScript
	{
		[Ordinal(0)]  [RED("onDeathCbId")] public CUInt32 OnDeathCbId { get; set; }

		public PassiveGlobalDeathCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
