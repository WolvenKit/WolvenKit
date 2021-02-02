using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animGraphSlotCondition : CVariable
	{
		[Ordinal(0)]  [RED("graph")] public rRef<animAnimGraph> Graph { get; set; }
		[Ordinal(1)]  [RED("condition")] public CHandle<animIStaticCondition> Condition { get; set; }

		public animGraphSlotCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
